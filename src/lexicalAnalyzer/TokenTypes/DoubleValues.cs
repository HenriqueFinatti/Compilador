using System;

namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class DoubleValues : AFD
    {
        public string tokenType = "DoubleValues";
        public bool isDouble = false;
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

                if (ASCIIcode == 46)
                {
                    isDouble = true;
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

                if (isDouble)
                {
                    return new Token(tokenType, token);
                }
            }
            return null;
        }
    }
}