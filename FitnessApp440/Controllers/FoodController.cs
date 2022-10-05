using Microsoft.AspNetCore.Mvc;

namespace FitnessApp440.Controllers
{

    public class FoodController : Controller
    {
        public IActionResult CreateFood()
        {
            return View();
        }

        [HttpPost]
        public JsonResult PostFood(string? name, string? desc, short calories, short protein, short carbs, short fat)
        {
            // TODO: add food to database and figure out a way to save an image maybe use Razor?

            return new JsonResult(Ok());
        }
    }
}

