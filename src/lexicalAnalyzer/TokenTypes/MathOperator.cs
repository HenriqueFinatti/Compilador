using System;

namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class MathOperator : AFD
    {
        protected string tokenType = "MathOperator";
        public override Token? evaluate(CharacterIterator sourceCode)
        {
            if (sourceCode.Current() == sourceCode.EOF)
            {
                return new Token("EOF", "$");
            }

            if (sourceCode.Current() == '+')
            {
                sourceCode.Next();
                return new Token(tokenType, "+");
            }

            if (sourceCode.Current() == '-')
            {
                sourceCode.Next();
                return new Token(tokenType, "-");
            }

            if (sourceCode.Current() == '*')
            {
                sourceCode.Next();
                return new Token(tokenType, "*");
            }

            if (sourceCode.Current() == '/')
            {
                sourceCode.Next();
                return new Token(tokenType, "/");
            }

            if (sourceCode.Current() == '%')
            {
                sourceCode.Next();
                return new Token(tokenType, "%");
            }
            return null;
        }
    }
}