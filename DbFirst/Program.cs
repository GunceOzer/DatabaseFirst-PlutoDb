using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
	class Program
	{
		static void Main(string[] args)
		{
			var dbContext = new PlutoDbContext(); // to access data from the database
			var courses = dbContext.GetCourses();
			
			foreach(var c in courses)
			{
				Console.WriteLine(c.Title);
			}

			
			var course = new Course();
			course.Level = CourseLevel.Advanced; //i  created a enum  and used it 
			
			Console.WriteLine(course.Level);
			Console.ReadKey();
		}
	}
}
