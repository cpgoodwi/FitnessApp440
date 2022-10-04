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
        public JsonResult CurrentUser()
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
        public JsonResult PostName(string name)
        {
            return new JsonResult(Ok());
        }

        [HttpGet]
        public JsonResult GetUserName()
        {
            return new JsonResult(Ok(new FitnessApp440.Models.UserViewModel()));
        }
    }
}
