using System;

namespace Compilador.lexicalAnalyzer
{
    public class CharacterIterator
    {
        private readonly string sourceCode;
        private int index;

        public char EOF = '\0';

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

        public char Current() { 
            if(index >= this.sourceCode.Length)
                return EOF;
                
            return this.sourceCode[index]; 
        }

        public void printCode()
        {
            Console.WriteLine(sourceCode);
        }

        public void setIndex(int newIndex)
        {
            this.index = newIndex;
        }

        public int getIndex()
        {
            return this.index;
        }
    }
}
