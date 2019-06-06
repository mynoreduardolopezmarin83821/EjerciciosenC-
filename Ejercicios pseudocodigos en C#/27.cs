

using System;

namespace Progra {
	class ejemplo_27 {

		static void Main(string[] args) {
			double contador;
			double limite;
			double num;
			num = 1;
			contador = 0;
			Console.WriteLine("Ingrese un numero limite");
			limite = Console.ReadLine();
			while (num<=limite) {
				if (num%2==0 && num%3==0) {
					Console.WriteLine(num);
					contador = contador+1;
				}
				num = num+1;
			}
			Console.WriteLine("El total de numeros multiplos de 2 y 3 encontrados es: "+contador);
		}

	}

}

