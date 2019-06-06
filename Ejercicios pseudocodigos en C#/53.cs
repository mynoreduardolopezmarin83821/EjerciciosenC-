

using System;

namespace Progra
{
	class ejemplo_53 {

		static void Main(string[] args) {
			string entrada;
			int i;
			int j;
			string[] dato = new string[20];
			for (i=1;i<=20;i++) {
				Console.WriteLine("Ingrese un numero");
				entrada = Console.ReadLine();
				dato[i-1] = entrada;
			}
			for (j=1;j<=20;j++) {
				Console.WriteLine(dato[j-1]+1);
			}
		}

	}

}

