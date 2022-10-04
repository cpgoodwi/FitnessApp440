using System;
using System.Web;
using System.Linq;
using System.Data;

namespace FitnessApp440.Models
{

    // This is an object for Food. This object should be used for any logic through the solution.

    /* TODO: implement constructor to get from database
     *  
     */

    public class FoodViewModel
    {
        public FoodViewModel() { }

        public int FoodID { get; set; }

        public String? Name { get; set; }

        public String? byUser { get; set; }

        public Int16 Calories { get; set; }

        public Int16 Protein { get; set; }

        public Int16 Carbs { get; set; }

        public Int16 Fat { get; set; }

        public String? Image { get; set; }

        public String? DescriptionText { get; set; }
        public DataRow Row { get; set; }

        public FoodViewModel(int foodID, string? name, string? byUser, short calories, short protein, short carbs, short fat, string? image, string? descriptionText)
        {
            FoodID = foodID;
            Name = name;
            this.byUser = byUser;
            Calories = calories;
            Protein = protein;
            Carbs = carbs;
            Fat = fat;
            Image = image;
            DescriptionText = descriptionText;
            /*Row = row;*/
        }

        public FoodViewModel(DataRow row)
        {
            Row = row;
        }
    }

    public class FoodRenderModel
    {

    }
}

