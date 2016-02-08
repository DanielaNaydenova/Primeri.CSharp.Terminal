using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Console.WriteLine ("Hello World!");

			//Примерен коментар на 1 ред

			/* Примерен многоредов коментар
			 * Ред 1
			 * Ред 2
			 * Ред 3
			 */

			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;

			//Събиране на числа
			a = 58;
			b = 10;

			sum = a + b;

			//Писане в конзолата
			Console.Write (a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine (sum);



		}
	}
}
