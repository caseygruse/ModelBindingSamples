using ModelBindingSamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBindingSamples.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			//Passing models to Views

			//ViewBag && ViewData
			//ViewBag and Data are dynamic and will crash at runtime if types are
			//incompatible and they use strings.

			//TempData
			//Just like ViewData EXCEPT data will last for one redirect.
			//ViewBag data is lost if redirected.

			Instructor instructor = GetInstructor();

			//passing an object through ViewBag && ViewData
			//ViewBag.Instructor = i;
			ViewData["Instructor"] = instructor;
			ViewData["Courses"] = instructor.Courses;

			
			return View();
		}

		private Instructor GetInstructor()
		{
			Course c1 = new Course()
			{
				CourseID = 5,
				Title = ".Net Web Programming"
			};

			Course c2 = new Course()
			{
				CourseID = 10,
				Title = "Java 101"
			};
			Instructor teach = new Instructor()
			{
				InstructorID = 1000,
				FullName = "Mr. Teacher"
			};
			teach.Courses.Add(c1);
			teach.Courses.Add(c2);
			return teach;
		}
		/// <summary>
		/// Tuples can return two types at once
		/// </summary>
		/// <returns></returns>
		private Tuple<string, bool> Test()
		{
			return new Tuple<string, bool>("97543211", false);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public string GetDate()
		{
			return DateTime.Today.ToShortDateString();
		}
	}
}