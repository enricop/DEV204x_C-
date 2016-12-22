using System;
using System.Collections;

namespace m7
{
	class Person {
		public string FirstName {get; set;}
		public string LastName {get; set;}
		public DateTime Birthdate;
		public string AddressLine1 {get; set;}
		public string AddressLine2 {get; set;}
		public string City {get; set;}
		public string State {get; set;}
		public string Province {get; set;}
		public int ZipCode;
		public string Country {get; set;}

		protected string[] fieldnames = new string[12]{"first name",
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

		public bool GetInformation() {
			string inputmessage = "Please Input the Student ";

			Console.WriteLine (inputmessage + fieldnames [0]);
			FirstName = Console.ReadLine();

			Console.WriteLine (inputmessage + fieldnames [1]);
			LastName = Console.ReadLine();

			ValidateBirthday();

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

			Console.WriteLine ("Successfully read data");
			return true;
		}

		public void PrintDetails()
		{
			Console.WriteLine("{0} {1} was born on: {2}", FirstName, LastName, Birthdate);
		}

		public static void PrintCiao() {
			Console.WriteLine("Ciao");
		}

		protected void ValidateBirthday() {
			string inputmessage = "Please Input the Field ";

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

	class Teacher : Person {
		public Teacher(string FirstName, string LastName) {
			this.FirstName = FirstName;
			this.LastName = LastName;
		}

		public void GradeTest() {

		}

	}

	class Student : Person {
		private static uint enrolled_students;

		public Stack Grades = new Stack();

		public void getNumberOfStudents() {
			Console.WriteLine("Enrolled Students: {0}", enrolled_students);
		}

		public Student(string FirstName, string LastName) {
			this.FirstName = FirstName;
			this.LastName = LastName;
			enrolled_students++;
		}

		public void TakeTest() {

		}
	}

	class Course {
		public string Name {get; set;}
		public uint Credits {get; set;}
		public uint Duration {get; set;}
		public Teacher[] teachers = new Teacher[3];
		public ArrayList students = new ArrayList();

		public Course(string Name) {
			this.Name = Name;
		}

		public void GetDegreeInformation() {
			var ex = new NotImplementedException ("method not implemented");
			throw ex;
		}

		public void PrintDegreeInformation() {
			var ex = new NotImplementedException ("method not implemented");
			throw ex;
		}

		public void ListStudents() {
			Console.WriteLine("Enrolled students are:");
			foreach (Student std in this.students) {
				Console.WriteLine ("student name: {0} {1}", std.FirstName, std.LastName);
			}
		}

	}

	class Degree {
		public string Name {get; set;}
		public uint Credits {get; set;}
		public Course curr_course;

		public Degree(string Name) {
			this.Name = Name;
		}

		public void GetDegreeInformation() {
			var ex = new NotImplementedException ("method not implemented");
			throw ex;
		}

		public void PrintDegreeInformation() {
			var ex = new NotImplementedException ("method not implemented");
			throw ex;
		}
	}

	class UProgram {
		public string Name {get; set;}
		public string Head {get; set;}
		public Degree curr_degree;

		public UProgram(string Name) {
			this.Name = Name;
		}

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
			Student std1 = new Student ("red", "sky");
			Student std2 = new Student ("black", "earth");
			Student std3 = new Student ("blue", "sea");

			std1.Grades.Push (12);
			std1.Grades.Push (28);
			std1.Grades.Push (15);
			std1.Grades.Push (30);
			std1.Grades.Push (28);

			std2.Grades.Push (12);
			std2.Grades.Push (28);
			std2.Grades.Push (15);
			std2.Grades.Push (30);
			std2.Grades.Push (28);

			std3.Grades.Push (12);
			std3.Grades.Push (28);
			std3.Grades.Push (15);
			std3.Grades.Push (30);
			std3.Grades.Push (28);

			Course mycourse = new Course ("Programming With C#");
			mycourse.students.Add (std1);
			mycourse.students.Add (std2);
			mycourse.students.Add (std3);

			mycourse.ListStudents ();

			return;
		}
	}
}
