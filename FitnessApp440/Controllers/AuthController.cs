using Azure.Identity;
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
        public JsonResult CreateSubmit(string username, string password)
        {
            // create new user in database with given params
            return new JsonResult(Ok());
        }

        [HttpPost]
        public JsonResult LoginSubmit(string username, string password)
        {
            // verify username and password are in database
            return new JsonResult(Ok());
        }
    }
}
