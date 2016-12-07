using System;
using LuaPraser.WjsTokenPraser;

namespace LuaPraser.WjsTokenParser
{
    public class Token
    {
        public int Column = 0;
        public int Line = 0;
        public long Id = 0;
        public TokenCategory Category = TokenCategory.EOF;
        public string Value = String.Empty;

        public Token() { }

        public Token(TokenCategory pCategory, string pValue)
        {
            Category = pCategory;
            Value = pValue;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", new object[] {Category.ToString(), Value});
        }
    }
}
