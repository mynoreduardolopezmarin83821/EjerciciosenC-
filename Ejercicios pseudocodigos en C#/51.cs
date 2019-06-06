
using System;

namespace Progra
{
	class ejemplo_51 {

		static void Main(string[] args) {
			double num1;
			double num2;
			Console.WriteLine("Ingrese el primer numero");
			num1 = Console.ReadLine();
			Console.WriteLine("Ingrese el segundo numero");
			num2 = Console.ReadLine();
			if (num2%num1==0) {
				Console.WriteLine(num1+" es multiplo de "+num2);
			}
		}

	}

}

