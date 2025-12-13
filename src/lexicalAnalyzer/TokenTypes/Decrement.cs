namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class Decrement : AFD
    {
        public override Token? evaluate(CharacterIterator sourceCode)
        {
            if (sourceCode.Current() == '-')
            {
                sourceCode.Next();
                if (sourceCode.Current() == '-')
                {
                    sourceCode.Next();
                    return new Token("Decrement", "--");
                }
            }

            return null;
        }
    }
}