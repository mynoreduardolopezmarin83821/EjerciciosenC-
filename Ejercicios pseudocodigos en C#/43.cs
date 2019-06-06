

using System;

namespace Progra
{
	class ejemplo_45 {

		static void Main(string[] args) {
			string a;
			double b;
			double contador;
			double contador_pares;
			double num;
			double suma_impares;
			contador_pares = 0;
			contador = 0;
			suma_impares = 0;
			Console.WriteLine("Ingrese un numero inicial");
			a = Console.ReadLine();
			Console.WriteLine("Ingrese un numero limite");
			b = Console.ReadLine();
			num = a;
			while (num<=b) {
				Console.WriteLine(num);
				if (num%2==0) {
					contador_pares = contador_pares+1;
				} else {
					suma_impares = suma_impares+num;
				}
				contador = contador+1;
				num = num+1;
			}
			Console.WriteLine("En el rango de "+a+" a "+b);
			Console.WriteLine("Se encontraron "+contador+" numeros en total");
			Console.WriteLine(contador_pares+" de ellos son pares");
			Console.WriteLine("La suma de los impares es "+suma_impares);
		}

	}

}

