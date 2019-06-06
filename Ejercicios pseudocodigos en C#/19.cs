// Este codigo ha sido generado por el modulo psexport 20150822-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejerc_19 {

		static void Main(string[] args) {
			double num;
			double suma_impar;
			double suma_par;
			num = 1;
			suma_par = 0;
			suma_impar = 0;
			while (num<=100) {
				Console.WriteLine(num);
				if (num%2==0) {
					suma_par = suma_par+num;
				} else {
					suma_impar = suma_impar+num;
				}
				num = num+1;
			}
			Console.WriteLine("La suma de los numero pares entre 1 y 100 es: "+suma_par);
			Console.WriteLine("La suma de los numero impares entre 1 y 100 es: "+suma_impar);
		}

	}

}

