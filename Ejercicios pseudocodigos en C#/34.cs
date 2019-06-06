

using System;

namespace Progra
{
	class ejemplo_34 {

		static void Main(string[] args) {
			double contador;
			double num1;
			double num2;
			double producto;
			contador = 0;
			Console.WriteLine("Ingresar dividendo");
			num1 = Console.ReadLine();
			Console.WriteLine("Ingresar divisor");
			num2 = Console.ReadLine();
			if (num1>0 && num2>0) {
				while (contador<num1) {
					contador = contador+1;
					producto = producto+num2;
				}
				Console.WriteLine("El producto es: "+producto);
			}
		}

	}

}

