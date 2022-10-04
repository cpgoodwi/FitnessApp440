using Microsoft.AspNetCore.Mvc;

namespace FitnessApp440.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult CreateFood()
        {
            return View();
        }
    }
}
