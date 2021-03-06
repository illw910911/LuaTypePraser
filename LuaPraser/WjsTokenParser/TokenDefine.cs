﻿namespace LuaPraser.WjsTokenParser
{
    public enum TokenCategory
    {
        EOL,
        EOF,
        EmptySpace,

    }

    public enum TerminalPriority
    {
        Zero = 0,
        Normal = 1000,
        High = 2000,
    }

    public class LuaTerminalNames
    {
        public const string Dot = ".",
        Colon = ":",
        Semic = ";",
        Comma = ",",
        Equal = "=",
        Comment = "comment",
        MultiComment = "multi comment",
        Identifier = "identifier",
        Chunk = "chunk",
        Block = "block",
        Statement = "statment",
        LastStatement = "last statment",
        FunctionName = "function name",
        VarList = "var list",
        Var = "var",
        NameList = "name list",
        ExprList = "expr list",
        Expr = "expr",
        PrefixExpr = "prefix expr",
        FunctionCall = "function call",
        Args = "args",
        NamedFunction = "named function",
        NamelessFunction = "unamed function",
        FunctionBody = "function body",
        ParList = "parlist",
        TableConstructor = "table construct",
        FieldList = "field list",
        Field = "field",
        FieldSeperator = "field sep",
        Binop = "bin op",
        Unop = "un op",
        String = "string",
        LongString = "string block",
        Number = "number",

        Assign = "assign",
        LoopBlock = "loop block",
        BranchBlock = "branch block",
        LocalVar = "local var";
    }
}
