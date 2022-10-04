using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessApp440.DataModel
{
    public class DBFoodModel
    {
        public int FoodID { get; set; }

        public String? Name { get; set; }

        public String? byUser { get; set; }

        public Int16 Calories { get; set; }

        public Int16 Protein { get; set; }

        public Int16 Carbs { get; set; }

        public Int16 Fat { get; set; }

        public String? Image { get; set; }

        public String? DescriptionText { get; set; }
    }
}

