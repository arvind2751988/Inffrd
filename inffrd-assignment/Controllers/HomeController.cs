using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using inffrd_assignment.Models;
using inffrd_assignment.ViewModel;
using inffrd_assignment.Repo;
using Newtonsoft.Json;

namespace inffrd_assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICategory _category;
        private readonly IExpense _expense;

        public HomeController(ILogger<HomeController> logger, ICategory category,IExpense expense)
        {
            _logger = logger;
            _category = category;
            _expense = expense;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SaveDetails(ExpenseViewModel model)
        {
            
            var result = _expense.AddExpense(model);
            return Json(result);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public JsonResult GetAllCategory()
        {
            var result = _category.GetCatgory();
            return Json(new { data = result });

        }

        public IActionResult DisplayExpenses()
        {
            IEnumerable<Category> result ;
            result = _category.GetAllCatgory();
            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
