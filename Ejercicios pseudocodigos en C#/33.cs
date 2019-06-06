
using System;

namespace Progra {
	class ejemplo_33 {

		static void Main(string[] args) {
			double factorial;
			double i;
			double num;
			factorial = 1;
			Console.WriteLine("Ingrese un numero para obtener el factorial");
			num = Double.Parse(Console.ReadLine());
			for (i=num;i>=1;i--) {
				factorial = factorial*i;
			}
			Console.WriteLine("El factorial de "+num+" es: "+factorial);
		}

	}

}

