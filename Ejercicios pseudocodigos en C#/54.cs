

using System;

namespace Progra
{
	class ejemplo_54 {

		static void Main(string[] args) {
			string num1;
			double num2;
			string producto;
			Console.WriteLine("Ingrese el primer numero");
			num1 = Console.ReadLine();
			Console.WriteLine("Ingrese el segundo numero");
			num2 = Double.Parse(Console.ReadLine());
			while (num2!=0) {
				producto = producto+num1;
				num2 = num2-1;
			}
			Console.WriteLine("El producto es "+producto);
		}

	}

}

