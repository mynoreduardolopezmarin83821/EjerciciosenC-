// Este codigo ha sido generado por el modulo psexport 20150822-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejerc_22 {

		static void Main(string[] args) {
			double contador;
			double maximo;
			double minimo;
			double n;
			contador = 0;
			n = 0;
			maximo = 0;
			minimo = 99999;
			while (contador<=5) {
				Console.WriteLine("Ingrese un numero: ");
				n = Double.Parse(Console.ReadLine());
				if (n>maximo) {
					maximo = n;
				}
				if (n<minimo) {
					minimo = n;
				}
				contador = contador+1;
			}
			Console.WriteLine("El mayor de los numeros es: ");
			Console.WriteLine(maximo);
			Console.WriteLine("El menor de los numeros es: ");
			Console.WriteLine(minimo);
		}

	}

}

