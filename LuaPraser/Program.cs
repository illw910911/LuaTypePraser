using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaPraser.LuaObject;
using LuaPraser.WjsTokenParser;
using LuaPraser.WjsTokenParser.Terminals;

namespace LuaPraser
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Terminal> l_terminals = new List<Terminal>();
            l_terminals.Add(new EOLTerminal());
            TokenParser.Instance.SetTerminals(l_terminals);
            string l_filePath = "E:\\Work\\LuaUnity\\Assets\\Lua\\View\\Intents\\AdventureIntent.lua";
            LuaFile l_file = new LuaFile(l_filePath);
            l_file.Parser();
        }
    }
}
