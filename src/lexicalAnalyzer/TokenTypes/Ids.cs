using System;
namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class Ids : AFD
    {
        public string buildToken(CharacterIterator sourceCode)
		{
			string token = "";

			while (true)
			{
                int ASCIIcode = (int)sourceCode.Current();

                if (ASCIIcode >= 65 && ASCIIcode <= 90)
                {
                    token += sourceCode.Current();
				    sourceCode.Next();
                    continue;
                }

                if (ASCIIcode >= 97 && ASCIIcode <= 122)
                {
                    token += sourceCode.Current();
				    sourceCode.Next();
                    continue;
                }

                if (ASCIIcode == 95)
                {
                    token += sourceCode.Current();
				    sourceCode.Next();
                    continue;
                }

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
            int ASCIIcode = (int)sourceCode.Current();
            // Verifying if the first character is A-Z or a-z or _
            if ((ASCIIcode >= 65 && ASCIIcode <= 90) || (ASCIIcode >= 97 && ASCIIcode <= 122) || ASCIIcode == 95)
            {
                string token = buildToken(sourceCode);
                return new Token("Id", token);
            }

            return null;
        }
    }
}