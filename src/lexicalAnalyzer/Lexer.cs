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
			this.afds.Add(new Increment());
			this.afds.Add(new Decrement());
			this.afds.Add(new AssignmentOperator());
			this.afds.Add(new LogicOperator());
			this.afds.Add(new RelationalOperator());
			this.afds.Add(new MathOperator());
			this.afds.Add(new DoubleValues());
			this.afds.Add(new CurlyBraces());
			this.afds.Add(new StringControl());
			this.afds.Add(new EndInstruction());
			this.afds.Add(new StringValues());
			this.afds.Add(new BooleanValues());
			this.afds.Add(new Parentheses());
			this.afds.Add(new CharacterValues());
			this.afds.Add(new IntegerValues());
			this.afds.Add(new Ids());
		}

		public void avoidWhiteSpaces()
        {
            while(characterIterator.Current() == ' ' || characterIterator.Current() == '\n' || characterIterator.Current() == '\r' || characterIterator.Current() == '\t')
            {
                characterIterator.Next();
            }
			avoidComments();
        }

		public void avoidComments()
        {
			if (characterIterator.Current() == '&')
            {
				characterIterator.Next();
            	while(characterIterator.Current() != '&')
                {
                    characterIterator.Next();
                }
				characterIterator.Next();
				avoidWhiteSpaces();
            }
        }

		public Token? searchNextToken()
        {
            int index = characterIterator.getIndex();

			foreach(AFD afd in afds)
            {
				if (characterIterator.Current() == characterIterator.EOF)
                {
                    return new Token("EOF", "$");
                }
				Token? token = afd.evaluate(characterIterator);
				if(token != null)
                {
                    return token;
                }
				characterIterator.setIndex(index);
            }
			return null;
        }
		public List<Token> getToken()
		{

			Token? token;
            do
            {
            	this.avoidWhiteSpaces();
				this.avoidComments();

				token = searchNextToken();

				if(token == null)
                {
                    throw new Exception("Error, token not recognized: " + characterIterator.Current());
                }
				tokens.Add(token);
            }while(characterIterator.Current() != characterIterator.EOF);

			return this.tokens;
		}
	}
}