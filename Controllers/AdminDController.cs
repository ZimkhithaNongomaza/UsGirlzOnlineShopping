using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopping2.Models;

namespace OnlineShopping2.Controllers
{
    public class AdminDController : Controller
    {
        private IDepartment repository;
        public AdminDController(IDepartment repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Departments);
        public ViewResult Edit(int departmentId) =>
 View(repository.Departments
 .FirstOrDefault(p => p.DeptID == departmentId));

        [HttpPost]
        public IActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                repository.SaveDepartment(department);
                TempData["message"] = $"{department.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(department);

            }
        }
        public ViewResult Create() => View("Edit", new Department());

        [HttpPost]
        public IActionResult Delete(int deptId)
        {
            Department deleteDepartment = repository.DeleteDepartment(deptId);
            if (deleteDepartment != null)
            {
                TempData["message"] = $"{deleteDepartment.Name} was deleted";
            }
            return RedirectToAction("Index");
        }
    }
}
