using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult User(string name, int id = 1)
        {
            ViewData["name"] = name;
            ViewData["id"] = id;
            return View();
        }
    }
}
