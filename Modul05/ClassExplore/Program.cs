using System;

namespace ClassExplore
{
	public class person
	{
		public string simpleString = "Тестова променлива от клас";

		public person()
		{
			simpleString = "Промяна на променлива при инициализиранме ";
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			// Дефиниране на клас
			person _person = new person();

			// Достъпване на клас
			Console.WriteLine (_person.simpleString);
		}
	}
}
