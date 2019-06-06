

using System;

namespace Progra
{
	class ejemplo_28 {

		static void Main(string[] args) {
			double contador;
			double num;
			double num_mayor;
			string resp;
			double suma_5;
			num_mayor = 0;
			suma_5 = 0;
			contador = 0;
			do {
				Console.WriteLine("Ingrese un numero");
				num = Double.Parse(Console.ReadLine());
				if (num%5==0) {
					suma_5 = suma_5+num;
				}
				if (num>num_mayor) {
					num_mayor = num;
				}
				contador = contador+1;
				Console.WriteLine("Desea ingresar otro numero (S/N)");
				resp = Console.ReadLine();
			} while (!(resp.Equals("no") || resp.Equals("NO") || resp.Equals("No") || resp.Equals("n") || resp.Equals("N")));
			Console.WriteLine("La suma de los multiplos de 5 es: "+suma_5);
			Console.WriteLine("El numero mayor de la serie ingresada es: "+num_mayor);
			Console.WriteLine("En total se ingresaron "+contador+" numeros");
		}

	}

}

