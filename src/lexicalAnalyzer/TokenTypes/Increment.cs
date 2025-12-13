namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class Increment : AFD
    {
        public override Token? evaluate(CharacterIterator sourceCode)
        {
            if (sourceCode.Current() == '+')
            {
                sourceCode.Next();
                if (sourceCode.Current() == '+')
                {
                    sourceCode.Next();
                    return new Token("Increment", "++");
                }
            }

            return null;
        }
    }
}