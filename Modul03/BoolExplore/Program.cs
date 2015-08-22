using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] _i = new int[] { 4, 3, 2 };

			int _ui = 0; //Convert.ToInt32 (Console.ReadLine());
			string _input = "0";

			Console.Write ("Моля въведете индекс: ");
			_input = Console.ReadLine ();

			bool _chek01 = int.TryParse (_input, out _ui);
			bool _chek02 = _ui <= _i.Length;
			bool _chek03 = _ui > 0;

			if (_chek01 && _chek02 && _chek03) {
				Console.WriteLine (_i [_ui - 1]);
						}
			if (!_chek01){Console.WriteLine ("Индексът не е цифра\n\n\n");}

			if (!_chek02){Console.WriteLine ("Индексът е голям\n\n\n");}

			if (!_chek03 && _chek01){Console.WriteLine ("Индексът е малък\n\n\n");}




		}
	}
}
