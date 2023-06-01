using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace OnlineShopping2.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        [Required(ErrorMessage = "Please enter a department name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a product description")]
        public string Description { get; set; }

    }
}
