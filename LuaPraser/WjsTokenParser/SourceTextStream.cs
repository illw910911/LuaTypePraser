using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaPraser.WjsTokenPraser
{
    public class SourceTextStream
    {
        private int m_curPos = 0;

        private string m_sourceText = "";

        public SourceTextStream(string pText)
        {
            m_sourceText = pText;
        }

        public int CurPos
        {
            get { return m_curPos; }
        }

        /// <summary>
        /// 先加指针后返回一个char
        /// </summary>
        /// <returns></returns>
        public char Next()
        {
           
            if (m_sourceText.Length > m_curPos)
            {
                char l_c = m_sourceText[m_curPos];
                m_curPos++;
                return l_c;
            }
            return '\0';
        }

        public char Cur()
        {
            if (m_sourceText.Length > m_curPos)
            {
                char l_c = m_sourceText[m_curPos];
                return l_c;
            }
            return '\0';
        }

        public int Length()
        {
            return m_sourceText.Length;
        }
        /// <summary>
        /// 将流置回初始位置
        /// </summary>
        public void ReturnToBegin()
        {
            m_curPos = 0;
        }

        public bool EndOfFile()
        {
            return m_curPos >= m_sourceText.Length ;
        }
    }
}
