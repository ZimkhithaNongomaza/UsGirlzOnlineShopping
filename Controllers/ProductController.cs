using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping2.Models;
using OnlineShopping2.Models.ViewModels;



namespace OnlineShopping2.Controllers
{
    public class ProductController:Controller
    {
        private IProduct repository;
        public int PageSize = 4;

        public ProductController(IProduct repo)
        {
            repository = repo;
        }
        public ViewResult List( string category, int productPage = 1)
            => View(new ProductListViewModel
            {
                Products = repository.Products
                .Where(p=> category==null || p.Category==category)
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category==null?
                    repository.Products.Count():
                    repository.Products.Where(e =>
                    e.Category==category).Count()
                },
                CurrentCategory=category
            }
            );
    }
}
