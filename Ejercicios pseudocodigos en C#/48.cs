

using System;

namespace Progra
{
	class ejemplo_48 {

		static void Main(string[] args) {
			double cociente;
			double diferencia;
			double num1;
			double num2;
			double producto;
			double resto;
			string suma;
			Console.WriteLine("Ingrese el primer numero");
			num1 = Double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el segundo numero");
			num2 = Double.Parse(Console.ReadLine());
			suma = num1+num2;
			producto = num1*num2;
			diferencia = num1-num2;
			cociente = num1/num2;
			resto = num1%num2;
			Console.WriteLine("La suma es "+suma);
			Console.WriteLine("El producto es "+producto);
			Console.WriteLine("La diferencia es "+diferencia);
			Console.WriteLine("El cociente es "+cociente);
			Console.WriteLine("El resto es "+resto);
		}

	}

}

