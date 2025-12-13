namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class CurlyBraces : AFD
    {
        public override Token? evaluate(CharacterIterator sourceCode)
        {
            if (sourceCode.Current() == '{')
            {
                sourceCode.Next();
                return new Token("Open Curly Braces", "{");
            }

            if (sourceCode.Current() == '}')
            {
                sourceCode.Next();
                return new Token("Closed Curly Braces", "}");
            }

            return null;
        }
    }
}