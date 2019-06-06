// Este codigo ha sido generado por el modulo psexport 20150822-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejerc_23 {

		static void Main(string[] args) {
			double contador;
			double cont_par;
			double num;
			string num1;
			double num2;
			double suma_impar;
			contador = 0;
			cont_par = 0;
			suma_impar = 0;
			Console.WriteLine("Ingrese el primer número");
			num1 = Console.ReadLine();
			Console.WriteLine("Ingrese el segundo numero");
			num2 = Console.ReadLine();
			num = num1;
			while (num<=num2) {
				Console.WriteLine(num);
				if (num%2==0) {
					cont_par = cont_par+1;
				} else {
					suma_impar = suma_impar+num;
				}
				contador = contador+1;
				num = num+1;
			}
			Console.WriteLine("Hay "+contador+" numeros entre "+num1+" y "+num2);
			Console.WriteLine(cont_par+" de ellos son pares");
			Console.WriteLine("La suma de los impares es "+suma_impar);
		}

	}

}

