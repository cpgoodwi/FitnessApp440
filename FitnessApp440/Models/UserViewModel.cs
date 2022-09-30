using System;
using System.Linq;
using System.Data;

namespace FitnessApp440.Models
{

    // This is an object for the User. This object should be used for any logic through the solution.

    public class UserViewModel
    {
      
        public int ID { get; set; }

        public String? UserName { get; set; }

        public String? Password { get; set; }

        public Int16 Height { get; set; }

        public Int16 Weight { get; set; }

        public Int16 GoalWeight { get; set; }

        public String? Description { get; set; }


    }
}


