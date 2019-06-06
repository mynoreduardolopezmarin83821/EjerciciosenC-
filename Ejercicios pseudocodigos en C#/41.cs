
using System;

namespace Progra {
	class ejemplo_41 {

		static void Main(string[] args) {
			double bin;
			double c;
			double i;
			double x;
			Console.WriteLine("Ingresa un numero entero");
			x = Console.ReadLine();
			if (x>0) {
				c = x;
				i = 1;
				bin = 0;
				while (c!=1) {
					bin = bin+(c%2)*i;
					c = Math.Truncate(c/2);
					i = i*10;
				}
				bin = bin+(c%2)*i;
				Console.WriteLine(bin);
			}
		}

	}

}

