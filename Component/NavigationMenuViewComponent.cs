using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping2.Models;

namespace OnlineShopping2.Component
{
    public class NavigationMenuViewComponent:ViewComponent
    {
        private IProduct repository;

        public NavigationMenuViewComponent(IProduct repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
       
    }
}
