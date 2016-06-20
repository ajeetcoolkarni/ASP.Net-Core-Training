using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCoreMVCApp.Models;

namespace MyCoreMVCApp.Controllers
{
    public class BankingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BankingHome()
        {
            return View();
        }

        public IActionResult BankingAboutUs()
        {
            return View();
        }

        public IActionResult BankingContact()
        {
            ViewData["ContactNo"] = 9845098450;
            ViewData["Email"] = "SomeBank@GlobalBank.com";
            ViewData["Person"] = "Some Person";

            return View();
        }

        public IActionResult AccountsInfo()
        {
            return View(new Account().GetData());
        }

        
    }
}