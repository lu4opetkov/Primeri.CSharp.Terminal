﻿using System;

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
				if (_usercommand.Contains("cmd03")) 
					{
						double a=0;
						if (cmd03(_usercommand, out a))
						{
							Console.WriteLine("a . a = " + a.ToString());
						}
						else
						{
							Console.WriteLine("Командата не е въведена коректно");	
						}
					}
				if (_usercommand.Contains("cmd04")) 
					{
						double _t = 5, _c = -2;
						if (cmd04 (ref _t))
						{
							Console.WriteLine(_t);
						}
						if (cmd04 (ref _c))
						{
							Console.WriteLine(_t);
						}
					}
				if (_usercommand.Contains("cmd05"))
					{

						Console.WriteLine ("\nБрой четни числа: "+ cmd05(_usercommand).Length.ToString());
					}
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
				else
				{
					Console.WriteLine("Командата не е въведена коректно");	
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
			else
			{
				Console.WriteLine ("Командата не е въведена коректно");	
			}
			return _temp;
		}
		public static bool cmd03 (string _input, out double _i)   // cmd03 45  --> 45*45
		{
			try
			{
				string _p = _input.Split(' ')[1];
				double __p = 0;
				if (double.TryParse(_p, out __p) )
				{
					_i = __p  *  __p;
					return true;
				}

			}catch{}

		_i = 0;
		return false;
		}
		public static bool cmd04 (ref double _i)
		{
			double _temp = _i;
			if (_i > 0) {
				_i = _i * _i;

			} 
			return (_temp > 0);
		}

		public static string[] cmd05 (string _input)
		{
			try
			{
				int _border = 0;
				string _temp = "";
				if (int.TryParse(_input.Split(' ')[1], out _border))
				{
					for (int i = 0; i < _border; i++)
					{
						if (i % 2 == 0)  _temp += i.ToString();

						if (i != _border-1 && i % 2 == 0)  _temp += ",";


					}
					Console.Write (_temp);  ///za proverka
					return _temp.Split (',');
				}

			}catch{
			}

			return new string[1]{ "0" };

		}
	}
}
