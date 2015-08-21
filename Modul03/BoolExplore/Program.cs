using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] _i = new int[] { 4, 3, 2 };

			int _ui = Convert.ToInt32 (Console.ReadLine());

			bool _chek01 = _ui <= _i.Length;
			bool _chek02 = _ui > 0;

			Console.WriteLine (_chek01);
			Console.WriteLine (_chek02);
			Console.WriteLine (_i[_ui - 1] );
		}
	}
}
