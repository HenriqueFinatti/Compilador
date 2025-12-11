using System;

namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class LogicOperator : AFD
    {
        protected string tokenType = "LogicOperator";
        public override Token? evaluate(CharacterIterator sourceCode)
        {
            if (sourceCode.Current() == 'A')
            {
                sourceCode.Next();
                if(sourceCode.Current() == 'N')
                {
                    sourceCode.Next();
                    if (sourceCode.Current() == 'D')
                    {
                        sourceCode.Next();
                        return new Token(tokenType, "AND");
                    }
                }
            }
            else if (sourceCode.Current() == 'N')
            {
                sourceCode.Next();
                if(sourceCode.Current() == 'O')
                {
                    sourceCode.Next();
                    if (sourceCode.Current() == 'T')
                    {
                        sourceCode.Next();
                        return new Token(tokenType, "NOT");
                    }
                }
            }
            else if(sourceCode.Current() == 'O')
            {
                sourceCode.Next();
                if (sourceCode.Current() == 'R')
                {
                    sourceCode.Next();
                    return new Token(tokenType, "OR");
                }
            }
            return null;
        }
    }
}