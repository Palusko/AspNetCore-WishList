using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        //index action
        public IActionResult Index()
        {
            return View("Index");
        }

        //error action
        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
