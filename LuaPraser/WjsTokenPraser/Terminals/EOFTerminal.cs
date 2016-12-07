using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaPraser.WjsTokenPraser.Terminals
{
    public class EOFTerminal :Terminal
    {
        public EOFTerminal()
        {
            m_matchSymbol = "\0";
            m_name = LuaTerminalNames.e
        }

        public override bool Match(SourceTextStream pSourceTextStream)
        {
            reg
        }

        public override Token CutOffToken(SourceTextStream pSourceTextStream)
        {
            
        }
    }
}
