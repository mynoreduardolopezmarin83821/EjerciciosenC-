// Este codigo ha sido generado por el modulo psexport 20150822-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejerc_6 {

		static void Main(string[] args) {
			double num;
			double suma;
			suma = 0;
			num = 100;
			while (num>=1) {
				if (num%2!=0) {
					Console.WriteLine(num);
					suma = suma+num;
				}
				num = num-1;
			}
			Console.WriteLine("La suma de los numero impares es: "+suma);
		}

	}

}

