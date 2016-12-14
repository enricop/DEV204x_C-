using System;

namespace DEV204x
{
	class Student {
		string FirstName;
		string LastName;
		int BirthdateYear;
		int BirthdateMonth;
		int BirthdateDay;
		string AddressLine1;
		string AddressLine2;
		string City;
		string State;
		string Province;
		int ZipCode;
		string Country;

		string[] fieldnames = new string[12]{"first name",
											"last name",
											"birth year",
											"birth month",
											"birth day",
											"address line 1",
											"address line 2",
											"city",
											"state",
											"province",
											"zip code",
											"country"
											};

		public bool readStudentData() {
			string inputmessage = "Please Input the Student ";

			Console.WriteLine (inputmessage + fieldnames [0]);
			FirstName = Console.ReadLine();

			Console.WriteLine (inputmessage + fieldnames [1]);
			LastName = Console.ReadLine();

			Console.WriteLine (inputmessage + fieldnames [2]);
			string tmp = Console.ReadLine();
			bool exitcode = Int32.TryParse (tmp, out BirthdateYear);
			if (!exitcode)
				return false;

			Console.WriteLine (inputmessage + fieldnames [3]);
			tmp = Console.ReadLine();
			exitcode = Int32.TryParse (tmp, out BirthdateMonth);
			if (!exitcode)
				return false;

			Console.WriteLine (inputmessage + fieldnames [4]);
			tmp = Console.ReadLine();
			exitcode = Int32.TryParse (tmp, out BirthdateDay);
			if (!exitcode)
				return false;

			Console.WriteLine (inputmessage + fieldnames [5]);
			AddressLine1 = Console.ReadLine();
	
			Console.WriteLine (inputmessage + fieldnames [6]);
			AddressLine2 = Console.ReadLine();

			Console.WriteLine (inputmessage + fieldnames [7]);
			City = Console.ReadLine();

			Console.WriteLine (inputmessage + fieldnames [8]);
			State = Console.ReadLine();

			Console.WriteLine (inputmessage + fieldnames [9]);
			Province = Console.ReadLine();

			Console.WriteLine (inputmessage + fieldnames [10]);
			tmp = Console.ReadLine();
			exitcode = Int32.TryParse (tmp, out ZipCode);
			if (!exitcode)
				return false;

			Console.WriteLine (inputmessage + fieldnames [11]);			
			Country = Console.ReadLine ();

			Console.WriteLine ("Successfully read student data");
			return true;
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Student newstudent;
			newstudent = new Student ();
			newstudent.readStudentData ();
			return;
		}
	}
}
