using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopping2.Models;


namespace OnlineShopping2.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployee repository;

        public EmployeeController (IEmployee repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Employees);
    }
}
