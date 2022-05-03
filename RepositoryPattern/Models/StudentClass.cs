using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RepositoryPattern.Models
{
     class StudentClass
     {
          [Key]
          public int stId { get; set; }
          public string stName { get; set; }
          public string email { get; set; }

     }
}
