using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcRuler.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}"); // Changed the welcome method to add two parametres (Following the PART2)
        ////}
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;                  // Chaned the welcome method for the printing the name witha hello in front
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}