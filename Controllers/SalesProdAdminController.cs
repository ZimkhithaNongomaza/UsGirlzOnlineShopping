using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopping2.Models;

namespace OnlineShopping2.Controllers
{
    public class SalesProdAdminController : Controller
    {
        private IProduct repository;
        public SalesProdAdminController(IProduct repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Products);
    }
}

