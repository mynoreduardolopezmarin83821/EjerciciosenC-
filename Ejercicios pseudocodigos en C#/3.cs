

using System;

namespace progra {
	class ejerc_3 {

		static void Main(string[] args) {
			double num;
			double resultado;
			double total;
			resultado = 0;
			while (num<=100) {
				num = num+1;
				resultado = num;
				total = resultado+num;
				Console.WriteLine(resultado);
			}
			Console.WriteLine("El resultado es: ");
			Console.WriteLine(resultado);
		}

	}

}

