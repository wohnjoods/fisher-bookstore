using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class Books : Controller{

        public IActionResult Index()
        {
            return Content("books default index action");
        }
        public IActionResult New()
        {
            return Content("book new book action");
        }
    
    }
}