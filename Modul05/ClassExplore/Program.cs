﻿using System;

namespace ClassExplore
{
	public class person
	{

		private string _userName = "";
		private string _userPass = "";

		public string userName
		{
			get {return _userName;}
		}
		public string userPass
		{
			get {return _userPass;}
		}

		private string _userID = "";
		private string _userFName = "";
		private string _userLName = "";

		public string userID 
		{
			get { return _userID; }
			set {_userID = value; }
		}
		public string userFName 
		{
			get { return _userFName; }
			set {_userFName = value; }
		}
		public string userLName
		{
			get { return _userLName; }
			set {_userLName = value; }
		}


		public person (string _user, string _pass)
		{
			_chekUser(_user, _pass);
		}
		private bool _chekUser (string _user, string _pass)
		{
			if (_user=="user" && _pass=="pass")
			{
				//Попълване на пропъртита
				userID = "ID: 44556456";
				userFName = "Лъчезар";
				userLName = "Петков";
				return true;
			}
			return false;
		}
			
	
			
	}

	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.Write("Потребител: "); string _user = Console.ReadLine ();
			Console.Write("ПАРОЛА: "); string _pass = Console.ReadLine ();

				// Дефиниране на клас;
			person _person = new person(_user,_pass);

			// Достъпване на клас
			Console.WriteLine(_person.userFName +" "+ _person.userLName);
			//Console.WriteLine (_person.getWelcomeMessage());
		}
	}
}
