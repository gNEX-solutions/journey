using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Journey.Controllers
{
    public class OAuthController : Controller
    {
        [HttpGet]
        public IActionResult Authorize()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Authorize(string userName)
        {
            return View();
        }


        public IActionResult Token()
        {
            return View();
        }
    }
}