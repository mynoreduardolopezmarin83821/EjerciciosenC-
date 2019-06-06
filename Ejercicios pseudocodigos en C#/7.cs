// Este codigo ha sido generado por el modulo psexport 20150822-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejerc_7 {

		static void Main(string[] args) {
			double limite;
			double num;
			Console.WriteLine("Ingrese un limite:");
			limite = Console.ReadLine();
			num = 1;
			while (num<=limite) {
				Console.WriteLine(num);
				num = num+1;
			}
		}

	}

}

