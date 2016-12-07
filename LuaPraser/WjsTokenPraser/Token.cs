using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuaPraser.WjsTokenPraser
{
    public class Token
    {
        public int Column = 0;
        public int Line = 0;
        public long Id = 0;
        public TokenCategory Category = TokenCategory.EOF;
    }
}
