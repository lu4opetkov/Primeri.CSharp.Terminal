using System;

namespace BoolExplore2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] _i = new int[] { 4, 3, 2 };

			int _ui = 0;
			string _input = "0";

			Console.Write ("Моля въведете индекс: ");
			_input = Console.ReadLine ();

			bool _chek01 = int.TryParse (_input, out _ui);



			try
			{
				Console.Write("Елемент " + _ui.ToString () +" e " );
				Console.WriteLine( _i[_ui -1 ]);
			}
			catch
			{
				Console.WriteLine("<Недефиниран елемент>" );
			}


//			Използване на логическо присвояване

//			_ui =(_ui >= _i.Length) ? _ui : 3;
//			_ui =(_ui < 0) ? _ui : 1;



// 			Използване на SWICH

//			switch (_ui) {
//			case 1:
//				{
//					Console.Write ("1ви елемент на масива ");
//					Console.WriteLine(_i[_ui-1]);
//					break;
//				}
//			case 2:
//				{
//					Console.Write ("2ри елемент на масива ");
//					Console.WriteLine(_i[_ui-1]);
//					break;
//				}
//			case 3:
//				{
//					Console.Write ("3ти елемент на масива ");
//					Console.WriteLine(_i[_ui-1]);
//					break;
//				}
//			default:
//				{
//					Console.Write ("В масива няма стойност за този индекс\n\nОпитайте с индекс (1-3)\n\n");
//					break;
//				}
			
			}

//			if (_chek01) {
//				Console.WriteLine (_i [_ui - 1]);
			
		}
	}


