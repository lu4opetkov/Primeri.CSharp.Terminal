using System;
using System.Collections.Generic;

namespace ListExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Деефиниции
			string _userinput = "";
			List<int> _list = new List<int> ();
			_list.Add (5);
			_list.Add (8);
			_list.Add (6);

			//потребителски вход
			do 
			{
				Console.Write("? ");
				_userinput = Console.ReadLine();

				// Добавяне на стойности
				if (_userinput.ToLower().Contains("add"))
				{
					try
					{
						int _add = 0;
						if (int.TryParse(_userinput.Split(' ')[1], out _add))
						{
							_list.Add(_add);
						}
						Console.WriteLine();
					}
					catch{}
				}

				// Преглед на List

				if (_userinput.Contains("show"))
				{
					Console.Write("list: ");
					for (int i = 0; i < _list.Count; i++)
					{
						Console.Write(_list[i]);
						if (i != _list.Count-1) Console.Write(", ");

					}
					Console.WriteLine();
				}
				//Размер на list

				if (_userinput.ToLower().Contains("size"))
				{
					Console.WriteLine("размер на списъка:" + _list.Count.ToString() + "\n\n");
				}

			}
			while(_userinput != "exit");
		}
	}
}
