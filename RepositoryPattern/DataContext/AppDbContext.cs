using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RepositoryPattern.Models;

namespace RepositoryPattern.DataContext
{
     class AppDbContext:DbContext
     {
          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
               optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=students;Integrated Security=True");
          }

          public DbSet<StudentClass> Studentobj { get; set; }
     }
}
