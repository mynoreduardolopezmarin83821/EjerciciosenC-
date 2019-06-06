

using System;

namespace Progra
{
	class ejemplo_29 {

		static void Main(string[] args) {
			string a;
			string b;
			double cantidad;
			string contador_pares;
			string suma_impares;
			double total;
			Console.WriteLine("Ingrese una cantidad");
			cantidad = Double.Parse(Console.ReadLine());
			if (cantidad<500) {
				total = cantidad+(cantidad*0.50);
			} else {
				if (cantidad>=500 && cantidad<1000) {
					total = cantidad+(cantidad*0.07);
				} else {
					if (cantidad>=1000 && cantidad<=5000) {
						total = cantidad-(cantidad*0.05);
					} else {
						total = cantidad;
					}
				}
			}
			Console.WriteLine("La nueva cantidad es: "+total);
			Console.WriteLine("Entre el rango de "+a+" y "+b);
			Console.WriteLine("Se encontraron "+contador_pares+" numeros pares");
			Console.WriteLine("La suma de los numeros impares es "+suma_impares);
		}

	}

}

