using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
	public class CourseService : ICourseService
	{
		// call repositoty or dependecy injection 

		private ICourseRepository _courseRepository;

		//Constractor and inject repository
		public CourseService(ICourseRepository courseRepository)
		{
			_courseRepository = courseRepository;
		}
		public CourseViewModel GetCourses()
		{
			return new CourseViewModel()
			{
				Courses = _courseRepository.GetCourses()
			};
		}
	}
}
