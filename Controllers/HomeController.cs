using GitGrupp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GitGrupp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // Added a comment for Liu from Kasleet
        // Added a comment to test git from Kasleet
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        // Adding a method to test a commit from Kasleet
        public void TestMethod()
        {
            Console.WriteLine("Hello World! I came to create Git Conflicts!");
            return;
        }
    }
}