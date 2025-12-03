using System;

namespace Compilador.lexicalAnalyzer
{
 	public abstract class AFD
	{
		public abstract Token? evaluate(CharacterIterator sourceCode);
	}   
}