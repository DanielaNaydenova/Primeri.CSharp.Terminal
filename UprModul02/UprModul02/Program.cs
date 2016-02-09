using System;

namespace UprModul02
{
	class MainClass
	{
		public static void Main (string[] args)

		/*Декларирайте две променливи от тип string и им присвоете стойности "Hello" и "World". 
		 * Декларирайте променлива от тип object и й присвоете стойността на конкатенацията на двете променливи от тип string 
		 * (не изпускайте интервала по средата). Декларирайте трета променлива от тип string и я инициализирайте със стойността 
		 * на променливата от тип object. ( Hint: Трябва да използвате type casting.)
		 */
		{
			string one = "Hello", two = "World";
			object five = (one + " " + two);
			Console.WriteLine (five);
		
			/*Да се въведат от командния ред 1 число или цифра и 1 дума/стринг. След това да изведе дължината на получения стринг 
		 * при конкатенация, тоест броя на символите в новополучения стринг при конкатенация. 
		 * (Hint: Трябва да преобразувате int към String и след това да конкатениратe.)*/
			int a = 0;
			string test = "";

			Console.Write ("Моля въведете цяло число: ");
			a = Convert.ToInt32 (Console.ReadLine ());

			Console.Write ("Моля въведете дума или израз: ");
			test = (Console.ReadLine ());

			Console.Write ("Резултатът от конкатенацията на а и тест е: ");
			Console.WriteLine (a + " " + test);


		}		
	}
}
