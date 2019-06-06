// Este codigo ha sido generado por el modulo psexport 20150822-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejerc_11 {

		static void Main(string[] args) {
			double contador;
			double limite;
			double num;
			double suma;
			Console.WriteLine("Ingrese un limite:");
			limite = Console.ReadLine();
			num = 1;
			contador = 0;
			suma = 0;
			while (num<=limite) {
				if (num%2==0) {
					Console.WriteLine(num);
					contador = contador+1;
					suma = suma+num;
				}
				num = num+1;
			}
			Console.WriteLine("Se encontraron "+contador+" numeros multiplos de 2");
			Console.WriteLine("La suma de ellos es "+suma);
		}

	}

}

