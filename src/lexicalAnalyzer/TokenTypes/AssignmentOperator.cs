using System;

namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class AssignmentOperator : AFD
    {
        public string tokenType = "AssignmentOperator";
        public override Token? evaluate(CharacterIterator sourceCode)
        {
            if (sourceCode.Current() == sourceCode.EOF)
            {
                return new Token("EOF", "$");
            }

            if (sourceCode.Current() == '<')
            {
                sourceCode.Next();
                if (sourceCode.Current() == '-')
                {
                    sourceCode.Next();
                    return new Token(tokenType, "<-");
                }
            }
            return null;
        }
    }
}