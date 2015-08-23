using System;

namespace ClassExplore
{
	public class person
	{
		private string simpleString = "Тестова променлива от клас";
		private string hidenString = "";
		private string user = "";

		public person (string _ini)

			{	
			getUser (_ini);
			setWelcometext ();
			}
		private void getUser (string _ini)
		{
			if (_ini == "password1")  hidenString = "Потребител 1";
			if (_ini == "password2")  hidenString = "Потребител 2";
		}

		private void setWelcometext()
		{
			user = hidenString;

			if (hidenString.Length > 0)
				simpleString = "Добре дошли отново ," + user +" !"; 
			else 
				simpleString ="Вие нямате достъп до тази програма !!!";
		}
		public string getWelcomeMessage()
		{
			return simpleString;
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
			Console.WriteLine (_person.getWelcomeMessage());
		}
	}
}
