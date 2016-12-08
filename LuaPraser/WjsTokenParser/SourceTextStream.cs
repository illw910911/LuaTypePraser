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

        private int m_markPos = -1;

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
            m_curPos++;
            if (m_sourceText.Length > m_curPos)
            {
                char l_c = m_sourceText[m_curPos];
                return l_c;
            }
            return '\0';
        }

        public void MarkPos()
        {
            m_markPos = m_curPos;
        }

        public void RevertPos()
        {
            if (m_markPos >= 0)
            {
                m_curPos = m_markPos;
                m_markPos = 0;
            }
        }

        public char PrevNextChar()
        {
            if (m_sourceText.Length > m_curPos + 1)
            {
                char l_c = m_sourceText[m_curPos + 1];
                return l_c;
            }
            return '\0';
        }

        public void Back()
        {
            m_curPos --;
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
