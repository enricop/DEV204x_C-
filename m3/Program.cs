using System;

namespace DEV204x
{
	class Student {
		string FirstName;
		string LastName;
		DateTime Birthdate;
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

		public bool GetStudentInformation() {
			string inputmessage = "Please Input the Student ";

			Console.WriteLine (inputmessage + fieldnames [0]);
			FirstName = Console.ReadLine();

			Console.WriteLine (inputmessage + fieldnames [1]);
			LastName = Console.ReadLine();

			ValidateStudentBirthday ();

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
			string ztmp = Console.ReadLine();
			bool xcode = Int32.TryParse (ztmp, out ZipCode);
			if (!xcode)
				return false;

			Console.WriteLine (inputmessage + fieldnames [11]);			
			Country = Console.ReadLine ();

			Console.WriteLine ("Successfully read student data");
			return true;
		}

		public void PrintStudentDetails()
		{
			Console.WriteLine("{0} {1} was born on: {2}", FirstName, LastName, Birthdate);
		}

		public static void PrintCiao() {
			Console.WriteLine("Ciao");
		}

		private void ValidateStudentBirthday() {
			string inputmessage = "Please Input the Student ";

			var ex = new ArgumentOutOfRangeException ("Input value not valid");

			do {
				try {
					Console.WriteLine (inputmessage + fieldnames [2]);
					string stmp = Console.ReadLine ();
					int dtmp;
					bool exitcode = Int32.TryParse (stmp, out dtmp);
					if (!exitcode)
						throw ex;
					else
						Birthdate = Birthdate.AddYears (dtmp);

					Console.WriteLine (inputmessage + fieldnames [3]);
					stmp = Console.ReadLine ();
					exitcode = Int32.TryParse (stmp, out dtmp);
					if (!exitcode)
						throw ex;
					else
						Birthdate = Birthdate.AddMonths (dtmp);

					Console.WriteLine (inputmessage + fieldnames [4]);
					stmp = Console.ReadLine ();
					exitcode = Int32.TryParse (stmp, out dtmp);
					if (!exitcode)
						throw ex;
					else
						Birthdate = Birthdate.AddDays (dtmp);

					break;
				} catch (ArgumentOutOfRangeException exception) {
					continue;
				}
			} while (true);
		}
	}

	class UProgram {
		string Name;
		string Head;
		string Degrees;
		public void GetUProgramInformation() {
			var ex = new NotImplementedException ("method not implemented");
			throw ex;
		}

		public void PrintUProgramInformation() {
			var ex = new NotImplementedException ("method not implemented");
			throw ex;
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Student newstudent;
			newstudent = new Student ();

			newstudent.GetStudentInformation ();
			newstudent.PrintStudentDetails ();

			Student.PrintCiao ();

			return;
		}
	}
}
