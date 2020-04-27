using ArchLimpio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchLimpio.Application.ViewsModels
{
    public class CourseViewModel
    {
        public IEnumerable<Curso> Courses { get; set; }
    }
}
