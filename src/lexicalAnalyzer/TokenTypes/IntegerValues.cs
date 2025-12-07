using System;

namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class IntegerValues : AFD
    {
        public string tokenType = "IntegerValues";
        public string buildToken(CharacterIterator sourceCode)
		{
			string token = "";
            while (true)
			{
                int ASCIIcode = (int)sourceCode.Current();

                if (ASCIIcode >= 48 && ASCIIcode <= 57)
                {
                    token += sourceCode.Current();
				    sourceCode.Next();
                    continue;
                }

                break;
			}

            return token;
		}
        public override Token? evaluate(CharacterIterator sourceCode)
        {

            if (sourceCode.Current() == sourceCode.EOF)
            {
                return new Token("EOF", "$");
            }

            int ASCIIcode = (int)sourceCode.Current();
            if (ASCIIcode >= 48 && ASCIIcode <= 57)
            {
                string token = buildToken(sourceCode);
                return new Token(tokenType, token);
            }
            return null;
        }
    }
}