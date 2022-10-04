using System;
using System.Linq;
using System.Data;

namespace FitnessApp440.Models
{

    // This is an object for the User. This object should be used for any logic through the solution.

    public class UserViewModel
    {
        public UserViewModel()
        {
            ID = 1;
            UserName = "username";
            Password = "password";
            Height = 100;
            Weight = 100;
            GoalWeight = 100;
            Description = "This is me";
        }

        public int ID { get; set; }

        public String? UserName { get; set; }

        public String? Password { get; set; }

        public byte Height { get; set; }

        public Int32 Weight { get; set; }

        public Int16 GoalWeight { get; set; }

        public String? Description { get; set; }


    }
}


