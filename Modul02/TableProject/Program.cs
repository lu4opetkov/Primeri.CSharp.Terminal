using System;

namespace TableProject
{
	class MainClass
	{
		enum ti {ime=0, familia, godini};
		public static void Main (string[] args)
		{
			//Дефиниране таблица
			string[,] table = new string[2,3];

			//въвеждане на 1 ви ред
			table[0, (int)ti.ime] = "Лъчезар";
			table[0, (int)ti.familia] = "Пламенов";
			table[0, (int)ti.godini] = "37";


			//Въвеждане на 2 ри ред
			table[1, (int)ti.ime] = "Пламен";
			table[1, (int)ti.familia] = "Лъчезаров";
			table[1, (int)ti.godini] = "35";


			//Печат
			Console.Write("Кой ред искате да видите: " );
			int _index = Convert.ToInt32 (Console.ReadLine ())-1;

			Console.WriteLine ((table[_index,(int)ti.ime])[0] +". " + table[_index,(int)ti.familia] + ", " + table[_index,(int)ti.godini] + "г.");
		}
	}
}






//			string[] row = new string[3];
//			row[0] = "Ред 1";
//			row[1] = "Ред 2";
//			row[2] = "Ред 3";
//
//			Console.WriteLine ("Масив ROW: " + row [0] + row [1] + row [2] + "\n");
//			string[] parse = "1,2,3,4,5,6,7,8,9".Split(',');
//			Console.WriteLine("Броят на масива: \n" + "1,2,3,4,5,6,7,8,9\n\n\ne:" + parse.Length );
//
//			string list1 = string.Join(";", parse);
//			Console.WriteLine("Новия стринг е:\n" + list1 + "\n\n" );