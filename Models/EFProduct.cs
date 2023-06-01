using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping2.Models
{
    public class EFProduct:IProduct
    {

        private ApplicationDbContext context;
        public EFProduct(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
