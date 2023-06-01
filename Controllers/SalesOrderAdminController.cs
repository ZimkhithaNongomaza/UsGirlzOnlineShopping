using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopping2.Models;
namespace OnlineShopping2.Controllers
{
    public class SalesOrderAdminController : Controller
    {
        private IOrder repository;
        public SalesOrderAdminController(IOrder repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Orders);
    }
}
