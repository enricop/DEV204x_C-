using System;

namespace m4
{
	public struct Student
	{
		// This is the custom constructor.
		public Student(string FirstName, string LastName)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Birthdate = DateTime.Today;
			this.AddressLine1 = "";
			this.AddressLine2 = "";
			this.City = "";
			this.State = "";
			this.Province = "";
			this.ZipCode = 0;
			this.Country = "";
		}

		public string FirstName;
		public string LastName;
		public DateTime Birthdate;
		public string AddressLine1;
		public string AddressLine2;
		public string City;
		public string State;
		public string Province;
		public int ZipCode;
		public string Country;
	}

	public struct Teacher
	{
		string FirstName;
		string LastName;
	}

	public struct Program
	{
		string Name;
	}

	public struct Course
	{
		string Name;
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Student[] stds = new Student[5];
			stds [0] = new Student("Mario", "Rossi");
			Console.WriteLine ("New student info: {0} {1}", stds [0].FirstName, stds [0].LastName);
		}
	}
}
