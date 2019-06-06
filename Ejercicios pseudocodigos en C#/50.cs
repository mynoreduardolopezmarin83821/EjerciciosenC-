

using System;

namespace Progra
{
	class ejemplo_50 {

		static void Main(string[] args) {
			double area;
			double diametro;
			double pi;
			double radio;
			Console.WriteLine("Ingrese el radio de la circunferencia");
			radio = Double.Parse(Console.ReadLine());
			diametro = radio*2;
			area = Math.PI*(Math.Pow(radio,2));
			Console.WriteLine("El diametro es "+diametro);
			Console.WriteLine("El area es "+area);
		}

	}

}

