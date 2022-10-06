//using Microsoft.AspNetCore.Mvc;
//using FitnessApp440.Models;
//using FitnessApp440.Helper;
//using FitnessApp440.Controllers;
//using System.Web;



//namespace FitnessApp440.Controllers
//{

//    public class EntryController : Controller
//    {

//        HomeController HomeController = new HomeController();

//        /*public IActionResult CreateFood()
//        {
//            return View();
//        }*/

//        // This method gets the input from user, stores it into the FoodViewModel and send it to the AddFoodToDatabase function. 
//        [HttpPost]
//        public ActionResult GetFoodEntry(FoodViewModel FoodViewModel)
//        {

//            string Name = FoodViewModel.Name;
//            string byUser = FoodViewModel.ByUser; // replace with code that gets session variable
//            int calories = FoodViewModel.Calories;
//            int protein = FoodViewModel.Protein;
//            int carbs = FoodViewModel.Carbs;
//            int fat = FoodViewModel.Fat;
//            string image = FoodViewModel.Image;
//            string descriptionText = FoodViewModel.DescriptionText;

//            AddFoodToDatabase(FoodViewModel);

//            return View();
//        }

//        [HttpPost]
//        public ActionResult GetUserEntry(UserViewModel UserViewModel)
//        {

//            string userName = UserViewModel.UserName;
//            string password = UserViewModel.Password;
//            int height = UserViewModel.Height;
//            int weight = UserViewModel.Weight;
//            int goalWeight = UserViewModel.GoalWeight;

//            AddUserToDatabase(UserViewModel);

//            return View();
//        }

//        // This method gets the data from GetFoodEntry, sends it to the SqlQuey for food entry and returns a  result string
//        public string AddFoodToDatabase(FoodViewModel FoodViewModel)
//        {

//            string foodEntryResult = "";

//            HomeController.TestSqlConnection();
//            foodEntryResult = HomeController.InsertFood(FoodViewModel);

//            return foodEntryResult;
//        }

//        public string AddUserToDatabase(UserViewModel UserViewModel)
//        {

//            string UserEntryResult = "";

//            HomeController.TestSqlConnection();
//            UserEntryResult = HomeController.InsertUser(UserViewModel);

//            return UserEntryResult;
//        }
//    }

//}
