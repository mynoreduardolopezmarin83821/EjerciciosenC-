

using System;

namespace Progra
{
	class ejemplo_47 {

		static void Main(string[] args) {
			double num;
			double suma;
			num = 1;
			suma = 0;
			while (num<=1000) {
				if (num%2!=0) {
					suma = suma+num;
				}
				num = num+1;
			}
			Console.WriteLine("La suma de los impares entre 1 y 1000, es "+suma);
		}

	}

}

