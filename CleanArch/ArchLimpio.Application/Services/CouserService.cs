using ArchLimpio.Application.Interfaces;
using ArchLimpio.Application.ViewsModels;
using ArchLimpio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchLimpio.Application.Services
{
    public class CouserService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CouserService(ICourseRepository courseRepository)
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
