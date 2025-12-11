
namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class CharacterValues : AFD
    {
        protected string tokenType = "CharacterValues";
        public override Token? evaluate(CharacterIterator sourceCode)
        {
            string token = "";
            if (sourceCode.Current() == '\'')
            {
                token += sourceCode.Current();

                sourceCode.Next();
                token += sourceCode.Current();

                sourceCode.Next();
                token += sourceCode.Current();

                if (sourceCode.Current() == '\'')
                {
                    sourceCode.Next();
                    return new Token(tokenType, token);
                }
            }
            return null;
        }
    }
}