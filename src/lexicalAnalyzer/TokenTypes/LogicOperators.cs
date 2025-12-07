using System;

namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class LogicOperator : AFD
    {
        protected string tokenType = "LogicOperator";
        public override Token? evaluate(CharacterIterator sourceCode)
        {
            string token;

            if (sourceCode.Current() == sourceCode.EOF)
            {
                return new Token("EOF", "$");
            }

            token = buildToken(sourceCode);

            if(token == "AND" || token == "NOT" || token == "OR")
            {
                return new Token(tokenType, token);
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