using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MovieListings.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "this is index";
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //return "this is mhy welcome";
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
