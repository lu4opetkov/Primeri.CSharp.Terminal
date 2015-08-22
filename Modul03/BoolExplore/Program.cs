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

			bool _exp01 = _chek01 && _chek02;   // Логическо И - "&&" 
			bool _exp02 = _chek01 || _chek02;   // Логическо ИЛИ - "||"
			bool _exp03 = !_chek01;  //Отрицание

			Console.WriteLine ("ЛОгическо И: " + _exp01.ToString());
			Console.WriteLine ("ЛОгическо ИЛИ: " + _exp02.ToString());
			Console.WriteLine ("Отрицание на " + _chek01.ToString() + " : " + _exp03);


			//Console.WriteLine (_i[_ui - 1] );
		}
	}
}
