using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping2.Models
{
    public interface IProduct
    {
        IQueryable<Product> Products { get; }
    }
}
