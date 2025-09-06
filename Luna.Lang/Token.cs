namespace Luna.Lang;

public class Token
{
    public TokenType Type { get; set; }
    public string Literal { get; set; }
}

public enum TokenType
{
    ILLEGAL,
    EOF,

    // Identifiers + literals
    IDENT,
    INT,

    // Operators
    ASSIGN,
    PLUS,

    // Delimiters
    COMMA,
    SEMICOLON,
    LPAREN,
    RPAREN,
    LBRACE,
    RBRACE,

    // Keywords
    FUNCTION,
    LET
}

public static class TokenTypeExtensions
{
    public static string ToString(this TokenType tokenType)
    {
        return tokenType switch
        {
            TokenType.ILLEGAL => "ILLEGAL",
            TokenType.EOF => "EOF",
            TokenType.IDENT => "IDENT",
            TokenType.INT => "INT",
            TokenType.ASSIGN => "=",
            TokenType.PLUS => "+",
            TokenType.COMMA => ",",
            TokenType.SEMICOLON => ";",
            TokenType.LPAREN => "(",
            TokenType.RPAREN => ")",
            TokenType.LBRACE => "{",
            TokenType.RBRACE => "}",
            TokenType.FUNCTION => "FUNCTION",
            TokenType.LET => "LET",
            _ => tokenType.ToString()
        };
    }
}