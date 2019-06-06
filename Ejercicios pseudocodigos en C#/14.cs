// Este codigo ha sido generado por el modulo psexport 20150822-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejerc_14 {

		static void Main(string[] args) {
			double num;
			double suma;
			while (num<=100) {
				if (num%2==0) {
					Console.WriteLine(num);
					suma = suma+(Math.Pow(num,2));
				}
				num = num+1;
			}
			Console.WriteLine("La suma de los numeros pares al cuadrado entre 0 y 100 es: "+suma);
		}

	}

}

