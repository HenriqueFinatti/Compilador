
namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class StringValues : AFD
    {
        protected string tokenType = "StringValues";
        public override Token? evaluate(CharacterIterator sourceCode)
        {
            string token = "";
            if (sourceCode.Current() == '\"')
            {
                token += sourceCode.Current();
                sourceCode.Next();
                token += sourceCode.Current();

                if (sourceCode.Current() == '\"')
                {
                    sourceCode.Next();
                    return new Token(tokenType, token);
                }

                while (sourceCode.Current() != '\"' && sourceCode.Current() != '\n' && sourceCode.Current() != '\t' && sourceCode.Current() != sourceCode.EOF)
                {
                    sourceCode.Next();
                    token += sourceCode.Current();
                }

                if (sourceCode.Current() == '\"')
                {
                    sourceCode.Next();
                    return new Token(tokenType, token);
                }
            }
            return null;
        }
    }
}