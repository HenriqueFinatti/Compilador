using System;

namespace Compilador.lexicalAnalyzer
{
	public class Token
	{
		string tipo;
		string lexema;

		public Token(string tipo, string lexema)
		{
			this.tipo = tipo;
			this.lexema = lexema;
		}

		public string getTipo()
		{
			return tipo;
		}

		public string getLexema()
		{
			return lexema;
		}

		public string toString()
		{
			return "<" + this.tipo + ", '" + this.lexema + "'>";
		}
	}
}