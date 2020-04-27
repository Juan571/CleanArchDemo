using ArchLimpio.Application.ViewsModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchLimpio.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
