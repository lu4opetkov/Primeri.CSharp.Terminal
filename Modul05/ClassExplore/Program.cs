﻿using System;

namespace ClassExplore
{
	public class person
	{
		public string simpleString = "Тестова променлива от клас";
		private string hidenString = "";
		public string user = "";

		public person (string _ini)

		{
			if (_ini == "password1")  hidenString = "Потребител 1";
			if (_ini == "password2")  hidenString = "Потребител 2";

			user = hidenString;

			if (hidenString.Length > 0)
				simpleString = "Добре дошли отново ," + user +"!!!"; 
			else 
				simpleString ="Вие нямате достъп до тази програма !!!";

		
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.Write("ПАРОЛА: "); string _user = Console.ReadLine ();
				// Дефиниране на клас;
			person _person = new person(_user);

			// Достъпване на клас
			Console.WriteLine (_person.simpleString);
		}
	}
}
