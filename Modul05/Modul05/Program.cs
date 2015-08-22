using System;

namespace Modul05
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции

			string _usercommand = "";

			//Потребителски команди

			do
			{
				Console.Write("$ "); _usercommand = Console.ReadLine();
				if (_usercommand.Contains("cmd01")) cmd01 (_usercommand);
				if (_usercommand.Contains("cmd02")) Console.WriteLine(cmd02 (_usercommand));
			}
			while(_usercommand != "exit");
		}
		public static void cmd01 (string _input) // cmd01 5 - 5^2
		{
			try 
			{
				double _temp = 0;
				if (double.TryParse(_input.Split(' ')[1],out _temp))
				{
					Console.WriteLine("\nРезултатът от " + _temp.ToString() + "^2 e:" + (_temp *_temp).ToString());
				}
			}catch{}
		}


		public static int cmd02 (string _input) // cmd02 5 - 5^3
		{
			int _temp = 0;
			if (int.TryParse(_input.Split(' ')[1],out _temp))
			{
				_temp = _temp * _temp * _temp;

			}
			return _temp;
		}
	}
}
