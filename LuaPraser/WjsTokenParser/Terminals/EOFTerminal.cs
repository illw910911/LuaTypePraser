using LuaPraser.WjsTokenPraser;

namespace LuaPraser.WjsTokenParser.Terminals
{
    public class EOFTerminal :Terminal
    {
        public EOFTerminal()
        {
            m_matchSymbol = "\0";
            m_name = LuaTerminalNames.Equal;
        }

        public override bool Match(SourceTextStream pSourceTextStream)
        {
            return false;
        }

        public override Token CutOffToken(SourceTextStream pSourceTextStream)
        {
            Token l_token = new Token();
            return l_token;
        }
    }
}
