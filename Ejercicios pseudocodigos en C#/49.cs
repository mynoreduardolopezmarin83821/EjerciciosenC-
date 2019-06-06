
using System;

namespace Progra
{
	class ejemplo_49 {

		static void Main(string[] args) {
			double media;
			string num1;
			string num2;
			string num3;
			double suma;
			Console.WriteLine("Ingrese el primer numero");
			num1 = Console.ReadLine();
			Console.WriteLine("Ingrese el segundo numero");
			num2 = Console.ReadLine();
			Console.WriteLine("Ingrese el tercer numero");
			num3 = Console.ReadLine();
			suma = num1+num2;
			media = suma/3;
			Console.WriteLine("La suma es "+suma);
			Console.WriteLine("La media aritmetica es "+media);
			if (num1>num2 && num1>num3) {
				Console.WriteLine("El mayor es:"+num1);
			} else {
				if (num2>num1 && num2>num3) {
					Console.WriteLine("El mayor es:"+num2);
				} else {
					if (num3>num1 && num3>num2) {
						Console.WriteLine("El mayor es:"+num3);
					} else {
						Console.WriteLine("Son iguales");
					}
				}
			}
			if (num1<num2 && num1<num3) {
				Console.WriteLine("El menor es: "+num1);
			} else {
				if (num2<num1 && num2<num3) {
					Console.WriteLine("El menor es: "+num2);
				} else {
					if (num3<num1 && num3<num2) {
						Console.WriteLine("El menor es: "+num3);
					} else {
						Console.WriteLine("Son iguales");
					}
				}
			}
		}

	}

}

