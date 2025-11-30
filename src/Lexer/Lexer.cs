using System;

public class Lexer
{
	string sourceCode;
	CharacterIterator characterIterator;

    public Lexer(string sourceCode)
	{
		this.sourceCode = sourceCode;
		this.characterIterator = new CharacterIterator(sourceCode);
	}

	public void getToken()
	{
		characterIterator.printCode();
	}
}
