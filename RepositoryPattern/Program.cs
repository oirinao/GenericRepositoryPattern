using System;
using System.Collections.Generic;
using System.Linq;
using RepositoryPattern.DataContext;
using RepositoryPattern.Models;


namespace RepositoryPattern
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine("Display student table");
               studentTable();
               Console.WriteLine("Preess enter to exit");
          }

          static void studentTable()
          {
               using(var results = new AppDbContext())
               {
                    List<StudentClass> student = results.Studentobj.ToList();
                    foreach(StudentClass stObj in student)
                    {
                         Console.WriteLine("{0} {1} {2}", stObj.stId, stObj.stName, stObj.email);
                    }
                    return;
               }
          }
     }
}
