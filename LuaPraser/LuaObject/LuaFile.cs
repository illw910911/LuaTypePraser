using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaPraser.WjsTokenParser;
using LuaPraser.WjsTokenPraser;

namespace LuaPraser.LuaObject
{
    public class LuaFile
    {
        private SourceTextStream m_sourceTextStream;
        private string m_filePath = String.Empty;
        private List<Token> m_tokens; 

        public LuaFile(string pPath)
        {
            m_filePath = pPath;
          
        }

        public void Parser()
        {
            Stream l_stream;
            try
            {
                l_stream = new FileStream(m_filePath, FileMode.Open);
            }
            catch (Exception)
            {
                throw;
            }
            StreamReader l_reader = new StreamReader(l_stream);
            m_sourceTextStream = new SourceTextStream(l_reader.ReadToEnd());

            m_tokens = TokenParser.Instance.Parser(m_sourceTextStream);
            List<Token> l_tokens = m_tokens;
        }
    }
}
