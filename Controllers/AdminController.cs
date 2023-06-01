using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopping2.Models;

namespace OnlineShopping2.Controllers
{
    public class AdminController : Controller
    {
        private IEmployee repository;
        public AdminController(IEmployee repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Employees);
        public ViewResult Edit(int employeeId) =>
 View(repository.Employees
 .FirstOrDefault(p => p.EmployeeID == employeeId));

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                repository.SaveEmployee(employee);
                TempData["message"] = $"{employee.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(employee);
            }

        }
        public ViewResult Create() => View("Edit", new Employee());

        [HttpPost]
        public IActionResult Delete(int empId)
        {
            Employee deleteEployee = repository.DeleteEmployee(empId);
            if (deleteEployee != null)
            {
                TempData["message"] = $"{deleteEployee.Name} was deleted";
            }
            return RedirectToAction("Index");
        }
    }
}
