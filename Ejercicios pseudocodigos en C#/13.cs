// Este codigo ha sido generado por el modulo psexport 20150822-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejerc_13 {

		static void Main(string[] args) {
			double contador;
			double limite;
			double num;
			double suma;
			contador = 0;
			suma = 0;
			Console.WriteLine("Ingrese un número menor a 500");
			limite = Console.ReadLine();
			if (limite>=500) {
				Console.WriteLine("El numero ingresado es mayor a 500");
			} else {
				num = limite;
				while (num<=500) {
					Console.WriteLine(num);
					contador = contador+1;
					suma = suma+num;
					num = num+8;
				}
				Console.WriteLine("Se encontraron "+contador+" numeros entre "+limite+" y 500");
				Console.WriteLine("La suma de ellos es "+suma);
			}
		}

	}

}

