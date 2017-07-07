using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AzureDemo.ViewModels;

namespace AzureDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new HomeViewModel());
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
