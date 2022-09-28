using FitnessApp440.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// Comment here test
// Michael stesting for push
// Morris test for push
// another michael test
// another Michael branch part 3
namespace FitnessApp440.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

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

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CreateAccount()
        {
            return View();
        }

        /* TODO Login Corner:
             * If user is logged in, allow navigation to profile and food journal
             * Else, prompt user to log in or create account
             * 
             * Optional Tasks:
             *  allow user to stay logged in on device
             *  on desktop, login form is a dropdown instead of new page
         */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}