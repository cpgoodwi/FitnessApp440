using FitnessApp440.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace FitnessApp440.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }

        [HttpGet]
        public JsonResult CurrentUser() // TODO: remove me
        {
            var names = new string[3]
            {
                "clara",
                "marc",
                "judy"
            };

            return new JsonResult(Ok(names));
        }

        [HttpPost]
        public JsonResult PostName(string name) // TODO: remove me
        {
            return new JsonResult(Ok());
        }

        [HttpGet]
        public JsonResult GetUserJSON(string username)
        {
            // get description from databse
            string desc = "I am charley";

            // declaring food from "database" for demo
            FoodViewModel banana = new FoodViewModel(1, "Banana", "charley", 100, 100, 100, 100, "Banana.jpg", "This is a banana");
            FoodViewModel bagel = new FoodViewModel(2, "Cheese Bagel", "charley", 100, 100, 100, 100, "Cheese_Bagel.JPG", "This is a Cheese Bagel");
            FoodViewModel hotDog = new FoodViewModel(3, "Costco Hot Dog", "charley", 100, 100, 100, 100, "Costco_Hot_Dog.jpeg", "This is a Costco Hotdog");

            // get a list of food posts from database
            FoodViewModel[] posts =
            {
                banana,
                bagel,
                hotDog
            };
            // get a list of food likes from database
            FoodViewModel[] likes =
            {
                banana,
                bagel
            };

            return new JsonResult(Ok(new UserRenderModel(username, desc, posts, likes)));
        }
    }
}
