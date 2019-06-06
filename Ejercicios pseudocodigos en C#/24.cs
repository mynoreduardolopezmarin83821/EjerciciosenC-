// Este codigo ha sido generado por el modulo psexport 20150822-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejerc_24 {

		static void Main(string[] args) {
			double cant;
			double datos;
			double num;
			datos = num;
			Console.WriteLine("Cuantos numeros desea ingresar");
			cant = Console.ReadLine();
			while (datos<=cant) {
				Console.WriteLine("Ingrese un numero");
				num = Console.ReadLine();
				if (num>10) {
					Console.WriteLine("El numero es MAYOR a 10");
				} else {
					Console.WriteLine("El numero es MENOR a 10");
				}
				datos = datos+1;
				Console.ReadKey();
			}
		}

	}

}

