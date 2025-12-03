using System;
using Compilador.lexicalAnalyzer.TokenTypes;

namespace Compilador.lexicalAnalyzer
{
    public class Lexer
	{
		string sourceCode;
		CharacterIterator characterIterator;
		List<AFD> afds = new List<AFD>();
		List<Token> tokens = new List<Token>();

		public Lexer(string sourceCode)
		{
			this.sourceCode = sourceCode;
			this.characterIterator = new CharacterIterator(sourceCode);
			this.afds.Add(new KeyWords());
		}

		public List<Token> getToken()
		{
			Token t1 = new Token("a", "b");
			Token t2 = new Token("a", "c");
			this.tokens.Add(t1);
			this.tokens.Add(t2);

			return this.tokens;
		}
	}
}