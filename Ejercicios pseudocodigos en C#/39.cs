
using System;

namespace Progra
{
	class ejemplo_37 {

		static void Main(string[] args) {
			double a;
			double b;
			double c;
			double i;
			double n;
			n = 30;
			a = 0;
			b = 1;
			for (i=1;i<=n;i++) {
				Console.WriteLine(a);
				c = a+b;
				a = b;
				b = c;
			}
		}

	}

}

