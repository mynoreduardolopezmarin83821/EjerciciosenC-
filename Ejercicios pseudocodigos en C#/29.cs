

using System;

namespace Progra
{
	class ejemplo_29 {

		static void Main(string[] args) {
			string a;
			double b;
			double contador;
			double contador_pares;
			double num;
			double suma_impares;
			contador = 0;
			contador_pares = 0;
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
				num = num+7;
			}
			Console.WriteLine("Entre el rango de "+a+" y "+b);
			Console.WriteLine("Se encontraron "+contador_pares+" numeros pares");
			Console.WriteLine("La suma de los numeros impares es "+suma_impares);
		}

	}

}

