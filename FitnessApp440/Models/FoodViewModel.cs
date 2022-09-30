using System;
using System.Linq;
using System.Data;

namespace FitnessApp440.Models
{

    // This is an object for Food. This object should be used for any logic through the solution.

    public class FoodViewModel
    {

        public int FoodID { get; set; }

        public String? Name { get; set; }

        public int Calories { get; set; }

        public int Protein { get; set; }

        public int Carbs { get; set; }

        public int Fat { get; set; }

        public String? Image { get; set; }

        public String? DescriptionText { get; set; }

    }
}

