using Assignment5Database.Models;
using Assignment5Database.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5Database.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBookRepository _repository;
        //says the number of books per page
        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IBookRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(string category, int pageNum = 1)
        {   //checks to ensure the info that is needed is within the db, if so it returns the book info
            if (ModelState.IsValid)
            {
                return View(new ProjectListViewModel
                {   //sets the pages
                    Projects = _repository.Projects
                                        .Where(p => category == null || p.Category == category)
                                        .OrderBy(p => p.BookId)
                                        .Skip((pageNum - 1) * PageSize)
                                        .Take(PageSize)
                            ,
                    PagingInfo = new PagingInfo
                    {//fixing the numbering when filtered
                        CurrentPage = pageNum,
                        ItemsPerPage = PageSize,
                        TotalNumItems = category == null ? _repository.Projects.Count() :
                                        _repository.Projects.Where(x => x.Category == category).Count()
                    },
                    CurrentCategory = category
                });
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
