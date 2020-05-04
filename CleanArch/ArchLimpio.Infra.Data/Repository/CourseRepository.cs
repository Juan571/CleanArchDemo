using ArchLimpio.Domain.Interfaces;
using ArchLimpio.Domain.Models;
using ArchLimpio.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchLimpio.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _ctx;

        public CourseRepository(UniversityDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Curso> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
