// Este codigo ha sido generado por el modulo psexport 20150822-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejerc_6 {

		static void Main(string[] args) {
			double contador;
			double num;
			num = 1;
			contador = 0;
			while (num<=100) {
				if (num%3==0) {
					Console.WriteLine(num);
					contador = contador+1;
				}
				num = num+1;
			}
			Console.WriteLine("Se encontraron "+contador+" numeros multiplos de 3");
		}

	}

}

