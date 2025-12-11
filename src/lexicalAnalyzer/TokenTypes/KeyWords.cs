using System;
namespace Compilador.lexicalAnalyzer.TokenTypes
{
	public class KeyWords : AFD
	{
		protected string tokenType = "KeyWords";
		protected string[] keyWords = { "int", "char", "string", "double", "bool", "void", "for", "while", "if", "input", "output" };


		public string buildToken(CharacterIterator sourceCode)
		{
			string token = "";
			int sizeControl = 0;

			while (sourceCode.Current() != ' ' && sourceCode.Current() != '\n' && sourceCode.Current() != '\t' && sourceCode.Current() != sourceCode.EOF && sizeControl < 6)
			{
				token += sourceCode.Current();
				sourceCode.Next();
				sizeControl++;
			}

			return token;
		}

		public override Token? evaluate(CharacterIterator sourceCode)
		{
			if (sourceCode.Current() == sourceCode.EOF)
            {
                return new Token("EOF", "$");
            }

			string token = this.buildToken(sourceCode);

			foreach(string keyWord in keyWords)
			{
				if(token == keyWord)
				{
					return new Token(tokenType, token);
				}
			}

			return null;
		}
	}
}