using System.IO;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CStask4.Models;

namespace CStask4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(string firstNumber, string secondNumber)
        {
            int num1 = int.Parse(firstNumber);
            int num2 = int.Parse(secondNumber);
            double result1 =0.0;
            double result2=0.0;
            bool negativenum = false;

            if(num1<0 || num2<0)
            {
                negativenum = true;
            }
            else
            {
                result1 = Math.Sqrt(num1);
                result2 = Math.Sqrt(num2);
                
            }

            ViewBag.negativenum = negativenum;
            ViewBag.num1 = num1;
            ViewBag.num2 = num2;
            ViewBag.Result1 = result1;
            ViewBag.Result2 = result2;
            
            return View();
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
