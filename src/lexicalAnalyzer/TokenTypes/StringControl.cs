namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class StringControl : AFD
    {
        public override Token? evaluate(CharacterIterator sourceCode)
        {
            if (sourceCode.Current() == ',')
            {
                sourceCode.Next();
                return new Token("String Control", ",");
            }

            return null;
        }
    }
}