

using System;

namespace Progra
{
	class ejemplo_52 {

		static void Main(string[] args) {
			double cuadrado;
			double cubo;
			double num;
			num = 1;
			while (num<=10) {
				cuadrado = Math.Pow(num,2);
				cubo = Math.Pow(num,3);
				Console.WriteLine(num+" "+cuadrado+" "+cubo);
				num = num+1;
			}
		}

	}

}

