using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class Authors : Controller{

        public IActionResult Index()
        {
            return Content("author default index action");
        }
        public IActionResult featured()
        {
            return Content("author featured action");
        }
       
    }
}