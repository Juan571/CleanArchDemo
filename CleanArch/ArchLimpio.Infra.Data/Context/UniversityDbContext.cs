using ArchLimpio.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchLimpio.Infra.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext (DbContextOptions options) : base(options)
        { 
            
        }

        public DbSet<Curso> Courses { get; set; }



    }
}
