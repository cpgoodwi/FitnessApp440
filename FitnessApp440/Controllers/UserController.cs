using Microsoft.AspNetCore.Mvc;

namespace FitnessApp440.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
