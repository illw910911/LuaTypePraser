using System;
using System.Collections.Generic;
using LuaPraser.WjsTokenPraser;

namespace LuaPraser.WjsTokenParser
{
    public class TokenParser
    {
        public static TokenParser Instance
        {
            get { return m_instance ?? (m_instance = new TokenParser()); }
        }

        private static TokenParser m_instance = null;
        private List<Terminal> m_terminals = new List<Terminal>();

        /// <summary>
        /// 通过一个文件流解析，返回一系列token
        /// </summary>
        /// <param name="pSourceTextStream"></param>
        /// <returns></returns>
        public List<Token> Parser(SourceTextStream pSourceTextStream)
        {
            if (pSourceTextStream == null)
                return null;
            if (m_terminals == null || m_terminals.Count < 0)
                return null;

            List<Token> l_tokens = new List<Token>();
            int l_stackOverLine = 100000000;
            int l_cycleCount = 0;

            do
            {
                Token l_token = null;
                //空格跳过
                while (pSourceTextStream.Cur() == ' ')
                {
                    pSourceTextStream.Next();
                }

                //根据终端列表切割token，当第一个切割成功，则至下一个
                for (int i = 0; i < m_terminals.Count; i++)
                {
                    Terminal l_terminal = m_terminals[i];
                    
                    if (l_terminal.Match(pSourceTextStream))
                    {
                        l_token = l_terminal.CutOffToken(pSourceTextStream);
                        //如果token值为空值，则出现异常，直接返回
                        if (string.IsNullOrEmpty(l_token.Value))
                        {
                            return l_tokens;
                        }
                        l_tokens.Add(l_token);
                        break;
                    }
                }
                if (l_token == null)
                {
                    break;
                }
                l_cycleCount++;
            } while (!pSourceTextStream.EndOfFile()||l_cycleCount > l_stackOverLine);
            return l_tokens;
        }

        private readonly Comparison<Terminal> m_terminalCompareRule = new Comparison<Terminal>((a, b) =>
        {
            if (a.Priority > b.Priority)
                return 1;
            else
                return 0;
        } ); 
        /// <summary>
        /// 设置终端器，用于截取token，是设置类似语法的东西
        /// </summary>
        /// <param name="pTerminals"></param>
        public void SetTerminals(List<Terminal> pTerminals)
        {
            m_terminals.Clear();
            m_terminals.AddRange(pTerminals);
            m_terminals.Sort(m_terminalCompareRule);
        }
    }
}
