using System;

namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class RelationalOperator : AFD
    {
        public string tokenType = "RelationalOperator";
        public override Token? evaluate(CharacterIterator sourceCode)
        {

            if (sourceCode.Current() == sourceCode.EOF)
            {
                return new Token("EOF", "$");
            }

            if (sourceCode.Current() == '>')
            {
                sourceCode.Next();

                if (sourceCode.Current() == '=')
                {
                    sourceCode.Next();
                    return new Token(tokenType, ">=");
                }

                return new Token(tokenType, ">");
            }

            if (sourceCode.Current() == '<')
            {
                sourceCode.Next();

                if (sourceCode.Current() == '=')
                {
                    sourceCode.Next();
                    return new Token(tokenType, "<=");
                }

                return new Token(tokenType, "<");
            }

            if (sourceCode.Current() == '=')
            {
                sourceCode.Next();
                return new Token(tokenType, "=");
            }

            if (sourceCode.Current() == '!')
            {
                sourceCode.Next();
                if (sourceCode.Current() == '=')
                {
                    sourceCode.Next();
                    return new Token(tokenType, "!=");
                }
            }
            return null;
        }

        public string buildToken(CharacterIterator sourceCode)
		{
			string token = "";

			while (sourceCode.Current() != ' ' && sourceCode.Current() != '\n' && sourceCode.Current() != '\r' && sourceCode.Current() != '\t' && sourceCode.Current() != sourceCode.EOF)
			{
				token += sourceCode.Current();
				sourceCode.Next();
			}

			return token;
		}
    }
}