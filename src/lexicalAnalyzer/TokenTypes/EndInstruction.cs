namespace Compilador.lexicalAnalyzer.TokenTypes
{
    public class EndInstruction : AFD
    {
        public override Token? evaluate(CharacterIterator sourceCode)
        {
            if (sourceCode.Current() == ';')
            {
                sourceCode.Next();
                return new Token("End Of Instruction", ";");
            }

            return null;
        }
    }
}