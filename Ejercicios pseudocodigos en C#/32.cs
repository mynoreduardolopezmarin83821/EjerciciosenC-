

using System;

namespace Progra
{
	class ejemplo_32 {

		static void Main(string[] args) {
			string a;
			double b;
			double contador;
			double num;
			double suma;
			contador = 0;
			suma = 0;
			Console.WriteLine("Ingrese un numero inicial");
			a = Console.ReadLine();
			Console.WriteLine("Ingrese un numero limite");
			b = Console.ReadLine();
			num = a;
			while (num<=b) {
				if (num%2==0) {
					Console.WriteLine(num);
					contador = contador+1;
					suma = suma+num;
				}
				num = num+1;
			}
			Console.WriteLine("Entre el rango de "+a+" y "+b);
			Console.WriteLine("Se encontraron "+contador+" numeros pares");
			Console.WriteLine("La suma de ellos es: "+suma);
		}     

	}

}

