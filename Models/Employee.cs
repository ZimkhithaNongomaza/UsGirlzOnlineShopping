using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace OnlineShopping2.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        public int GradeLevel { get; set; }
    
        public int DeptID { get; set; }
        [Required(ErrorMessage = "Please enter an employee name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter an employee surname")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please enter an employee gender")]
        public string Gender { get; set; }

    }
}
