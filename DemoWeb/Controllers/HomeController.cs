using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoWeb.Models;

namespace DemoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISender sender;

        public HomeController(ISender sender)
        {
            this.sender = sender;
        }
        public IActionResult Index()
        {
            return Content(sender.Send("Email From My Web Site.Donot Reply","Please Confirm Account","amir.falahmanesh@yahoo.com"));
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
