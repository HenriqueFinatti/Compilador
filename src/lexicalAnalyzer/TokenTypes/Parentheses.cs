namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class Parentheses : AFD
    {
        public override Token? evaluate(CharacterIterator sourceCode)
        {
            if (sourceCode.Current() == '(')
            {
                sourceCode.Next();
                return new Token("Open Parentheses", "(");
            }

            if (sourceCode.Current() == ')')
            {
                sourceCode.Next();
                return new Token("Closed Parentheses", ")");
            }

            return null;
        }
    }
}