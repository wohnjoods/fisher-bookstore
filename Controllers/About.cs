using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class About : Controller{

        public IActionResult Index()
        {
            return Content("about default index action");
        }
        public IActionResult history()
        {
            return Content("about history index action");
        }
         public IActionResult location()
        {
            return Content("about location index action");
        }
    }
}