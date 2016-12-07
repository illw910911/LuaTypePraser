using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaPraser.WjsTokenPraser;

namespace LuaPraser.WjsTokenParser.Terminals
{
    public class EOLTerminal:Terminal
    {
        public override bool Match(SourceTextStream pSourceTextStream)
        {
            return true;
        }

        public override Token CutOffToken(SourceTextStream pSourceTextStream)
        {
            Token l_token;
            char l_char = pSourceTextStream.Cur();
            StringBuilder l_builder = new StringBuilder();
            while (!CharMatch(l_char))
            {
                l_builder.Append(l_char);
                l_char = pSourceTextStream.Next();
            }

            //多种匹配，下一个字符如果还是匹配，则继续下一个字符，多种结合在一起
            while (CharMatch(l_char))
            {
                l_char = pSourceTextStream.Next();
            }

            l_token = new Token(TokenCategory.EOL, l_builder.ToString());
            return l_token;
        }

        private bool CharMatch(char pChar)
        {
            return pChar == '\r' || pChar == '\n' || pChar == '\0';
        }
    }
}
