

using System;

namespace Progra
{
	class ejemplo_40 {

		static void Main(string[] args) {
			double cant_a_mostrar;
			double cant_mostrados;
			bool es_primo;
			double i;
			double n;
            double rc; n;
			Console.WriteLine("Ingrese la cantidad de numeros primos a mostrar:");
			cant_a_mostrar = Console.ReadLine();
			Console.WriteLine("1: 2");
			cant_mostrados = 1;
			n = 3;
			while (cant_mostrados<cant_a_mostrar) {
				es_primo = true;
				for (i=3;i<=Math.Sqrt(n);i+=2) {
					if (n%i==0) {
						es_primo = false;
					}
				}
				if (es_primo) {
					cant_mostrados = cant_mostrados+1;
					Console.WriteLine(cant_mostrados+": "+n);
				}
				n = n+2;
			}
		}

	}

}

