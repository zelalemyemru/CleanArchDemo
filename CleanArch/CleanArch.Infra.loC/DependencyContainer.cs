using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interface;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.loC
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			// Application layer
			services.AddScoped<ICourseService, CourseService>();
			// Data layer (Infra.Data)
			services.AddScoped<ICourseRepository, CourseRepository>();


		}
	}
}
