using System;
using Compilador.lexicalAnalyzer;

namespace Compilador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceCodePath = @"C:\Users\rickf\OneDrive\Documentos\git\Compilador\SourceCode.txt";

            if (File.Exists(sourceCodePath))
            {
                string sourceCode = File.ReadAllText(sourceCodePath);
                Lexer lexer = new Lexer(sourceCode);
                List<Token> tokens = lexer.getToken();

                foreach(Token t in tokens)
                {
                    Console.WriteLine(t.toString());
                }
                
            }

        }
    }
}
