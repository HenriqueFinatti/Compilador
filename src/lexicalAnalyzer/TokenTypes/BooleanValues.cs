using System;

namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class BooleanValues : AFD
    {
        public string tokenType = "BooleanValues";
        public override Token? evaluate(CharacterIterator sourceCode)
        {

            if (sourceCode.Current() == 't')
            {
                sourceCode.Next();
                if (sourceCode.Current() == 'r')
                {
                    sourceCode.Next();
                    if (sourceCode.Current() == 'u')
                    {
                        sourceCode.Next();
                        if (sourceCode.Current() == 'e')
                        {
                            sourceCode.Next();
                            return new Token(tokenType, "true");
                        }
                    }
                }
            }
            else if (sourceCode.Current() == 'f')
            {
                sourceCode.Next();
                if (sourceCode.Current() == 'a')
                {
                    sourceCode.Next();
                    if (sourceCode.Current() == 'l')
                    {
                        sourceCode.Next();
                        if (sourceCode.Current() == 's')
                        {
                            sourceCode.Next();
                            if (sourceCode.Current() == 'e')
                            {
                                sourceCode.Next();
                                return new Token(tokenType, "false");
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}