namespace Luna.Lang;

public class Token
{
  public string Type { get; }
  public string Literal { get; }

  public Token(string type, string literal)
  {
    Type = type;
    Literal = literal;
  }

  public Token(string type, char literal) : this(type, literal.ToString()) { }
}
