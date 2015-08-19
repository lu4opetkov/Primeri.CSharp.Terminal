using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		
			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;

			//Събиране на числа
			a = 10;
			b = 5;
			sum = a + b;
			string program_name = "Modul02 - Примери";
			string program_version = "1.0";
			// За програмата
			Console.WriteLine (program_name);
			Console.WriteLine ("Версия = "+ program_version + "\n\n");


			//Писане в козола 
			Console.Write (a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine (sum);

			// Допълнителни оператори
			Console.WriteLine ("\nИзползване на +=");
			a += b; // a=10 +5  : a=a+b
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на -=");
			a -= b;
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на *=");
			a *= b;
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на ++");
			a++;
			Console.WriteLine (a);

			a = 15; b = 10;

			Console.WriteLine ("\nСтандартно делене");
			Console.WriteLine (a/b); // 1

			Console.WriteLine ("\nХващане на остатък");
			Console.WriteLine (a%b); //5

			Console.WriteLine (program_name);

		}
	}
}
