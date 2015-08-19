using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 5, b = 0;

			//Въвеждане на входни параметри
			Console.Write("Моля въведете B: ");
			b = Convert.ToInt32(Console.ReadLine ());


			//Резулатат
			Console.WriteLine ("Резулата а+б е "+ (a+b).ToString ()+"\n\n\n");

			string test = "1";

			test += ", 2";
			test += ", 333";
			test += ", 4";
			test += ", 5";
			test += ", 6";

			Console.WriteLine ("Събиране с += " + test+ "\n");
			test = test.Replace (", " , "-");
			Console.WriteLine ("TEST - Replace : " + test + "\n");
			Console.WriteLine ("3ти знак e " + test.Split('-')[2]+ "\n");
		}
	}
}
