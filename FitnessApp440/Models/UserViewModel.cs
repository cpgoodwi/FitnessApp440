using System;
using System.Linq;
using System.Data;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using FitnessApp440.Helper

namespace FitnessApp440.Models
{

    // This is an object for the User. This object should be used for any logic through the solution.
    // TODO: this object needs to be reworked; it should only store the information necessary to view
    // should include an array/list of liked foods and foods posted for viewing on the profile

    public class UserViewModel // TODO: remove this comepletly and rename UserRenderModel to this
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

        // TODO: Constructor that creates gets a user given a username and returns the name, liked posts, and posts by user

        public int ID { get; set; } // TODO; remove this because we are just using username as the ID

        public String? UserName { get; set; }

        public String? Password { get; set; } // TODO: probably want to remove this

        public byte Height { get; set; } // probably want to remove this

        public Int32 Weight { get; set; } // probably want to remove this

        public Int16 GoalWeight { get; set; } // probably want to remove this

        public String? Description { get; set; } // can keep this


    }

    public class UserRenderModel // TODO: Refactor UserViewModel to this where appropriate
    {
        public string? UserName { get; set; }
        public string? Description { get; set; }
        public FoodViewModel[] FoodPosts { get; set; }
        public FoodViewModel[] LikedFood { get; set; }

        public UserRenderModel(string? userName, string? description, FoodViewModel[] foodPosts, FoodViewModel[] likedFood)
        {
            UserName = userName;
            Description = description;
            FoodPosts = foodPosts;
            LikedFood = likedFood;
        }

        public UserRenderModel(string? userName)
        {
            UserName = userName;
            Description = SqlConnection.GetDescriptionByUserName(userName);
            FoodPosts = SqlConnection.GetFoodPostsByUserName(userName);
            LikedFood = SqlConnection.GetLikedFoodByUserName(userName);
        }
    }
}


