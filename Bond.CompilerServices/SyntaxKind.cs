namespace Bond.CompilerServices
{
    public enum SyntaxKind : byte
    {
        None = 0,

        // punctuation
        DotToken = 30,     // .
        CommaToken,        // ,
        ColonToken,        // :  
        SemicolonToken,    // ;
        OpenBracketToken,  // <
        CloseBracketToken, // >
        OpenBraceToken,    // {
        CloseBraceToken,   // }
        OpenParenToken,    // (
        CloseParenToken,   // )
        EqualsToken,       // =

        // keywords
        BoolKeyword = 50,
        Uint8Keyword,
        Uint16Keyword,
        Uint32Keyword,
        Uint64Keyword,
        Int8Keyword,
        Int16Keyword,
        Int32Keyword,
        Int64Keyword,
        FloatKeyword,
        DoubleKeyword,
        StringKeyword,
        WstringKeyword,

        // container
        BlobKeyword,
        ListKeyword,
        VectorKeyword,
        SetKeyword,
        MapKeyword,
        NullableKeyword,


        NamespaceToken = 100,
        UsingToken,
        StructToken,
        EnumToken,
        NothingToken,
        ValueToken,

        StringLiteralToken,
    }
}