using LuaPraser.WjsTokenPraser;

namespace LuaPraser.WjsTokenParser
{
    public abstract class Terminal
    {
        protected string m_name = "";
        protected string m_matchSymbol = "";
        protected int m_priority = (int)TerminalPriority.Zero;
        /// <summary>
        /// 处于字符优先级
        /// </summary>
        public int Priority
        {
            get { return m_priority; }
        }

        public string Name
        {
            get { return m_name; }
        }

        public abstract bool Match(SourceTextStream pSourceTextStream);

        /// <summary>
        /// 从字符流中截取一个token，同时字符流标志位向后移动
        /// </summary>
        /// <param name="pSourceTextStream"></param>
        /// <returns></returns>
        public abstract Token CutOffToken(SourceTextStream pSourceTextStream);
    }
}
