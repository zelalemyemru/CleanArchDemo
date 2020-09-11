using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModels
{
	public class CourseViewModel
	{
		// list all courses in course
		public IEnumerable<Course> Courses { get; set; }

	}
}
