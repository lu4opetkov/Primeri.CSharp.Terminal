using System;

namespace Fact
{
	class MainClass
	{
		public static int Fact (int _fact)
		{
			if (_fact <= 1)
				return 1;
			else
				return _fact * Fact (_fact - 1);
			// 2!            2  *  1 
			// 3!          3  *   2  *  1
		}



		public static void Main (string[] args)
		{
			// 5! = 5*4*3*2*1    0! =1
			 

			Console.WriteLine ("3! = " + Fact (3));
			Console.WriteLine ("4! = " + Fact (4));
			Console.WriteLine ("5! = " + Fact (5));
			Console.WriteLine ("6! = " + Fact (6));
			Console.WriteLine ("7! = " + Fact (7));
			Console.WriteLine ("8! = " + Fact (8));
		}
	}
}
