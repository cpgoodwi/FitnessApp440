using Microsoft.AspNetCore.Mvc;
using FitnessApp440.Models;
using FitnessApp440.Helper;
using FitnessApp440.Controllers;
using System.Web;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace FitnessApp440.Controllers
{

    public class FoodController : Controller
    {
        HomeController HomeController = new HomeController();

    

        public IActionResult CreateFood()
        {
            return View();
        }
        public IActionResult AddFood()
        {
            return View();
        }

        [Obsolete]
        private readonly IHostingEnvironment hostingEnvironment;

        [Obsolete]
        public FoodController(IHostingEnvironment environment)
        {
            hostingEnvironment = environment;
        }

        // This method gets the input from user, stores it into the FoodViewModel and send it to the AddFoodToDatabase function. 
        [HttpPost]
        public ActionResult GetFoodEntry(FoodViewModel newFood)
        {
            var img = newFood.Image;
            var fileName = Path.GetFileName(newFood.Image.FileName);
            var contentType = newFood.Image.ContentType;

            if(newFood.Image != null)
            {


                var uniqueImageName = GetUniqueFileName(newFood.Image.FileName);
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "img");
                var filePath = Path.Combine(uploads, uniqueImageName);
                newFood.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                newFood.ImageLcation = uniqueImageName;
                var ImageRandomName = RandomString(10);
            }
                        
            string Name = newFood.Name;
            string byUser = newFood.ByUser; // replace with code that gets session variable
            int calories = newFood.Calories;
            int protein = newFood.Protein;
            int carbs = newFood.Carbs;
            int fat = newFood.Fat;
            // take image file from form upload and move it to ~/wwwroot/img directory
            // and rename the image to a generated string and set that as the value for the image
            string descriptionText = newFood.DescriptionText;

            AddFoodToDatabase(newFood);

            return View();
        }

        [HttpPost]
        public ActionResult GetUserEntry(UserViewModel newUser) // TODO: add this to user controller
        {

            string userName = newUser.UserName;
            string password = newUser.Password;
            int height = newUser.Height;
            int weight = newUser.Weight;
            int goalWeight = newUser.GoalWeight;

            AddUserToDatabase(newUser);

            return View();
        }

        // This method gets the data from GetFoodEntry, sends it to the SqlQuey for food entry and returns a  result string
        public string AddFoodToDatabase(FoodViewModel newFood)
        {

            string foodEntryResult = "";

            HomeController.TestSqlConnection();
            foodEntryResult = HomeController.InsertFood(newFood);

            return foodEntryResult;
        }

        public string AddUserToDatabase(UserViewModel UserViewModel) // TODO: move this to user controller
        {

            string UserEntryResult = "";

            HomeController.TestSqlConnection();
            UserEntryResult = HomeController.InsertUser(UserViewModel);

            return UserEntryResult;
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string GetUniqueFileName(string fileName)
        {

            string fileNametesting = "";

            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
    }
}

