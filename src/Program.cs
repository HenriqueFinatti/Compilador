namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\rickf\OneDrive\Documentos\git\Compilador\SourceCode.txt";
          
            if (File.Exists(path))
            {
                string sourceCode = File.ReadAllText(path);
                Lexer lexer = new Lexer(sourceCode);
                lexer.getToken();
            }
        }
    }
}
