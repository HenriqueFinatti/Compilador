using System;
namespace Compilador.lexicalAnalyzer.TokenTypes
{
	public class KeyWords : AFD
	{
		protected string tokenType = "keyWords";
		protected string[] keyWords = { "int", "char", "string", "double", "bool", "true", "false", "void", "for", "while", "if", "input", "output" };


		public string buildToken(CharacterIterator sourceCode)
		{
			string token = "";

			while (sourceCode.Current() != ' ' && sourceCode.Current() != '\n' && sourceCode.Current() != '\t' && sourceCode.Current() != sourceCode.EOF)
			{
				token += sourceCode.Next();
			}

			return token;
		}
		
		public override Token evaluate(CharacterIterator sourceCode)
		{
			int firstIndex = sourceCode.getIndex();
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