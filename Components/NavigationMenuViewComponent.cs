using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5Database.Models;

namespace Assignment5Database.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private IBookRepository repository;

        public NavigationMenuViewComponent (IBookRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {   //selects what listings should be returned
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Projects
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
