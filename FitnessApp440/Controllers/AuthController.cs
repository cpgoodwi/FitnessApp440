using Azure.Identity;
using FitnessApp440.Models;
using Microsoft.AspNetCore.Mvc;

/* TODO: IMPORTANTx2: implement sessions for the user
 * TODO: implement log out functionality
 */

namespace FitnessApp440.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginSubmit(string username, string password)
        {
            // TODO: find username in database and check if password matches: return boolean

            return View("../Home/Index");
        }

        public IActionResult CreateSubmit(string username, string password, string confirm)
        {
            // TODO: add username and password to database. default description should be "I am {username}" maybe add option to edit later

            return View("../Home/Index");
        }

        public IActionResult Logout()
        {
            return View("../Home/Index");
        }
    }
}
