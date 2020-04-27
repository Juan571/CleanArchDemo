using ArchLimpio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchLimpio.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Curso> GetCourses();
    }
}
