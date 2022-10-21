using FitnessApp440.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FitnessApp440.Helper;
using System.Data.SqlClient;

/* TESTING GIT */

/* TODO: spread sql methods to other controllers */

namespace FitnessApp440.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ActivatorUtilitiesConstructor]
        public HomeController()
        {
        }

        //public HomeController()
        //{
        //}

        // This method starts running all the method when the app starts 
        public IActionResult Index()
        {
            /*TestSqlConnection();
            InsertUser();
            InsertFood();
            FoodListResult();
            UserListResult();*/
            return View();
        }

        // This method test the connection to the Sql Database and returns a string with the result.
        public string TestSqlConnection()
        {

            string ConnectionCheck;
            ConnectionCheck = Helper.SqlConnection.EstablishConnection();
            return ConnectionCheck;
        }

        // This method gets the list of Food data and retuns the list.
        public List<FoodViewModel> FoodListResult()
        {
            List<FoodViewModel> foodViewModelList = new List<FoodViewModel>();
            foodViewModelList = Helper.SqlConnection.RunFoodQuery();
            return foodViewModelList;
        }

        // This method gets the list of User data and retuns the list.
        public List<UserViewModel> UserListResult()
        {
            List<UserViewModel> UserViewModelList = new List<UserViewModel>();
            UserViewModelList = Helper.SqlConnection.RunUserQuery();
            return UserViewModelList;
        }

        // This method gets the info inputted to the user to be added to the Database
        public string InsertFood(FoodViewModel foodViewModelUserEntry)
        {
            string insetFoodResult;
           // FoodViewModel foodViewModelUserEntry = new FoodViewModel();
            insetFoodResult = Helper.SqlConnection.SproucFoodInsert(foodViewModelUserEntry);
            return insetFoodResult;
        }

        // This method gets user data inputted to be added to the Database
        public string InsertUser(UserViewModel UserViewModel)
        {
            string insertUserResult;
            UserViewModel userViewModelUserEntry = new UserViewModel();
            insertUserResult = Helper.SqlConnection.SproucUserInsert(userViewModelUserEntry);
            return insertUserResult;
        }



        public IActionResult Privacy()
        {
            return View();
        }

        /*public IActionResult Profile()
        {
            return View();
        }*/

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