using System;

namespace ListExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Деефиниции
			string _userinput = "";

			//потребителски вход
			do 
			{
				Console.Write("? ");
				_userinput = Console.ReadLine();
			}
			while(_userinput != "exit");
		}
	}
}
