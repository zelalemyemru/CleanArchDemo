using CleanArch.Domain.Interface;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
	public class CourseRepository : ICourseRepository
	{
		private UniveristyDBContext _ctx; // injection
										  // constructor.
		public CourseRepository(UniveristyDBContext ctx)
		{
			_ctx = ctx;
		}

		public IEnumerable<Course> GetCourses()
		{
			return _ctx.Courses;
		}
	}
}
