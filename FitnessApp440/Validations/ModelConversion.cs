using System;
using FitnessApp440.Models;
using FitnessApp440.DataModel;
namespace FitnessApp440.Validations
{
    public class FoodViewModels
    {
        public DBFoodModel ModelToDataModel (FoodViewModel foodViewModel)
        {
            DBFoodModel dBFoodModel = new DBFoodModel();

            dBFoodModel.Name = foodViewModel.Name;
            dBFoodModel.byUser = foodViewModel.ByUser;
            dBFoodModel.Calories = foodViewModel.Calories;
            dBFoodModel.Protein = foodViewModel.Protein;
            dBFoodModel.Carbs = foodViewModel.Carbs;
            dBFoodModel.Fat = foodViewModel.Fat;
            dBFoodModel.Image = foodViewModel.Image;
            dBFoodModel.DescriptionText = foodViewModel.DescriptionText;

            return dBFoodModel;
        }
    }
}

