

using System;

namespace Progra
{
	class ejemplo_35 {

		static void Main(string[] args) {
			double a;
			double b;
			double c;
			double neg;
			double raizcua;
			string resp;
			double totalx1;
			double totalx2;
			Console.WriteLine("Ingrese el valor de a");
			a = Double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el valor de b");
			b = Double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el valor de c");
			c = Double.Parse(Console.ReadLine());
			neg = -b;
			raizcua = Math.Pow((Math.Pow(b,2)-4*a*c),0.5);
			if (raizcua<=0) {
				Console.WriteLine("La ecuacion no se puede resolver");
			} else {
				totalx1 = (neg+raizcua)/(2*a);
				totalx2 = (neg-raizcua)/(2*a);
				Console.WriteLine("X1 = "+totalx1);
				Console.WriteLine("X2 = "+totalx2);
			}
			Console.WriteLine("Desea realizar otra ecuacion (S/N)");
			resp = Console.ReadLine();
		}

	}

}

