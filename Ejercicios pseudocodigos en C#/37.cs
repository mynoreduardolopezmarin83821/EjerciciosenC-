

using System;

namespace PSeInt {
	class ejemplo_37 {

		static void Main(string[] args) {
			double contador;
			double control;
			double num;
			control = 10;
			contador = 1;
			Console.WriteLine("Ingrese un numero");
			num = Console.ReadLine();
			while (control<=num) {
				contador = contador+1;
				control = control*10;
			}
			Console.WriteLine("El numero "+num+" tiene "+contador+" cifras");
		}

	}

}

