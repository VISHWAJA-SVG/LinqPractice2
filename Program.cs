using System;
using System.Linq;
using System.Collections.Generic;


namespace LinqDemoExa
{
	

	public class Program
	{
		public static void Main()
		{
			// Student collection
			IList<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
				new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
			};
			//method syntax
			var filteredResult = studentList.Where((s, i) => {
				if (i % 2 == 0) // if it is even element
					return true;

				return false;
			});

			foreach (var std in filteredResult)
				Console.WriteLine(std.StudentName);
		}
	}

	public class Student
	{

		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }

	}
}

//for Query syntax

//var filteredResult = from s in studentList
//where s.Age > 12
// where s.Age< 20
//select s;

