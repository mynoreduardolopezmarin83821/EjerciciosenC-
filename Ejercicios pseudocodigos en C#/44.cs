

using System;

namespace Progra
{
	class ejemplo_44 {

		static void Main(string[] args) {
			double contador;
			double dividendo;
			double divisor;
			Console.WriteLine("Ingrese el dividendo");
			dividendo = Double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el divisor");
			divisor = Double.Parse(Console.ReadLine());
			contador = 0;
			while (dividendo>=divisor) {
				dividendo = dividendo-divisor;
				contador = contador+1;
			}
			Console.WriteLine("El cociente es "+contador);
			Console.WriteLine("El resto es "+dividendo);
		}

	}

}

