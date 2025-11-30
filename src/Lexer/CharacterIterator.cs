using System;

public class CharacterIterator
{
    private readonly string sourceCode;
    private int index;

    public const char EOF = '\0';

    public CharacterIterator(string sourceCode)
	{
        this.sourceCode = sourceCode;
        this.index = 0;
    }

    public char Next()
    {
        if(index >= this.sourceCode.Length)
            return EOF;

        return this.sourceCode[index++];
    }

    public void printCode()
    {
        Console.WriteLine(sourceCode);
    }
}
