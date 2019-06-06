
using System;

namespace Progra {
	class ejemplo_26 {

		static void Main(string[] args) {
			double limite;
			double num;
			double suma;
			double suma_multiplos_5;
			suma = 0;
			suma_multiplos_5 = 0;
			Console.WriteLine("Ingrese un numero limite");
			limite = Console.ReadLine();
			while (num<=limite) {
				if (num%5==0) {
					suma_multiplos_5 = suma_multiplos_5+num;
				} else {
					Console.WriteLine(num);
					suma = suma+num;
				}
				num = num+1;
			}
			Console.WriteLine("La suma de los numeros entre 0 y "+limite+" sin los multiplos de 5 es: "+suma);
			Console.WriteLine("La suma de los multiplos de 5 es: "+suma_multiplos_5);
		}

	}

}

