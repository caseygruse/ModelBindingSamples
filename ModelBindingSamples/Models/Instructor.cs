using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBindingSamples.Models
{
	public class Instructor
	{
		public Instructor()
		{
			Courses = new List<Course>();
		}

		public int InstructorID { get; set; }

		public string FullName { get; set; }

		public ICollection<Course> Courses { get; set; }
	}
}