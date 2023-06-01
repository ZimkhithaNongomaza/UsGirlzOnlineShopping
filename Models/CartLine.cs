using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace OnlineShopping2.Models
{
    public class CartLine
    {
      
        [Key]
        public int CartLneID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
