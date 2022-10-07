using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using FitnessApp440.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace FitnessApp440.Helper
{

    // This class is connections to the SQL Database
    public static class SqlConnection
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter da;
        private static MySqlDataReader dr;


        // This class builds a string connection and uses it to connect to the database.
        // It returns a string that tells you if the connect is sucessful and send it to the controller
        public static string EstablishConnection()
        {
            string ConnectionResult;
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "107.180.1.16";
            builder.UserID = "440fall20224";
            builder.Password = "440fall20224";
            builder.Database = "440fall20224";
            builder.SslMode = MySqlSslMode.None;
            connection = new MySqlConnection(builder.ToString());
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                ConnectionResult = " Database Connection Successful";
            }
            else
            {
                ConnectionResult = "Connection Failed";
            }

            return ConnectionResult;
        }

        // This method search the database and return a list of data in the Food table.
        // The list will be sent to the controller so it can sent to the client to display the data.
        public static List<FoodViewModel> RunFoodQuery()
        {
            EstablishConnection();

            List<FoodViewModel> foodEntriesList = new List<FoodViewModel>();


            if (connection.State == ConnectionState.Open)
            {
                string sqlQuery = "select * from FOOD where image is not null;";
                using var cmd = new MySqlCommand(sqlQuery, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                foreach (DataRow row in dt.Rows)
                {

                    var foodID = (int)row[0];
                    var byUser = (string)row[1];
                    var name = (string)row[2];
                    var calories = (short)row[3];
                    var protein = (short)row[4];
                    var carbs = (short)row[5];
                    var fat = (short)row[6];
                    var imageLcation = (string)row[7];
                    var descriptionText = (string)row[8];

                    foodEntriesList.Add(new FoodViewModel(foodID, name, byUser, calories, protein, carbs, fat, imageLcation, descriptionText));

                }

                connection.Close();
            }

            else
            {
                connection.Close();
            }

            return foodEntriesList;

        }

        // This method search the database and return a list of data in the User table.
        // The list will be sent to the controller so it can sent to the client to display the data.
        public static List<UserViewModel> RunUserQuery()
        {
            UserViewModel userViewModel = new UserViewModel();
            List<UserViewModel> userViewModelList = new List<UserViewModel>();

            if (connection.State == ConnectionState.Open)
            {

                string sqlQuery = "select * from USER";
                using var cmd = new MySqlCommand(sqlQuery, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    userViewModel.UserName = row.ItemArray[0] as string;
                    userViewModel.Password = row.ItemArray[1] as string;
                    userViewModel.Height = (byte)row.ItemArray[2];
                    userViewModel.Weight = Convert.ToInt16(row.ItemArray[3]);
                    userViewModel.GoalWeight = Convert.ToInt16(row.ItemArray[4]);

                    userViewModelList.Add(userViewModel);

                }
            }

            else
            {
                connection.Close();
            }

            return userViewModelList;

        }

        // This method is a store procedure that sends a command to the database to insert what food items that gets sent from the user.
        // It has returns a string that determine if the user entry to add the item was sucessful.
        // This string should be displayed to the client.
        public static string SproucFoodInsert(FoodViewModel foodViewModelEntry)
        {
            string entryresult = "";
            int queryResult;

            if (connection.State == ConnectionState.Open)
            {

                string sqlQuery = "Sprouc_AddFood";
                using var cmd = new MySqlCommand(sqlQuery, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@byUser", foodViewModelEntry.ByUser = "username10");
                cmd.Parameters.AddWithValue("@name", foodViewModelEntry.Name);
                cmd.Parameters.AddWithValue("@calories", foodViewModelEntry.Calories);
                cmd.Parameters.AddWithValue("@protein", foodViewModelEntry.Protein);
                cmd.Parameters.AddWithValue("@carbs", foodViewModelEntry.Carbs);
                cmd.Parameters.AddWithValue("@fat", foodViewModelEntry.Fat);
                cmd.Parameters.AddWithValue("@image", foodViewModelEntry.ImageLcation);
                cmd.Parameters.AddWithValue("@description", foodViewModelEntry.DescriptionText);
                queryResult = cmd.ExecuteNonQuery();

                if (queryResult == 1)
                {
                    entryresult = "Food has been added!";
                }
                else
                {
                    entryresult = "Food entry has Failed. Please try again!";
                }


            }

            return entryresult;
        }


        // This method is a store procedure that sends a command to the database to insert user info that gets sent from the controller.
        // It has returns a string that determine if the user entry to add the item was sucessful.
        // This string should be displayed to the client.
        public static string SproucUserInsert(UserViewModel userViewModelEntry)
        {
            string entryresult = "";
            int queryResult;

            if (connection.State == ConnectionState.Open)
            {
                string sqlQuery = "Sprouc_AddUser";
                using var cmd = new MySqlCommand(sqlQuery, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", userViewModelEntry.UserName);
                cmd.Parameters.AddWithValue("@password", userViewModelEntry.Password);
                cmd.Parameters.AddWithValue("@height", userViewModelEntry.Height);
                cmd.Parameters.AddWithValue("@weight", userViewModelEntry.Weight);
                cmd.Parameters.AddWithValue("@goal_weight", userViewModelEntry.GoalWeight);
                queryResult = cmd.ExecuteNonQuery();

                if (queryResult == 1)
                {
                    entryresult = "User has been added!";
                }
                else
                {
                    entryresult = "User entry has Failed. Please try again!";
                }

            }

            return entryresult;
        }

/*========================================================================
        CHARLEY'S SQL METHODS
 =======================================================================*/

        public static string GetDescriptionByUserName(string username)
        {
            /*  TODO: run sql query that gets a description value from database
             *  query might look like:
             *  select DESCRIPTION from USER where USERNAME = <username>;
             */

            return "";
        }

        public static FoodViewModel[] GetFoodPostsByUserName(string username)
        {
            /*  TODO: run sql query that gets a description value from database
             *  query might look like:
             *  select * from FOOD where BYUSER = <username>;
             */

            FoodViewModel[] foodPosts = new FoodViewModel[1]; // this is just example code

            return foodPosts;
        }

        public static FoodViewModel[] GetLikedFoodByUserName(string username)
        {
            /*  TODO: run sql query that gets a description value from database
             *  query might look like:
             *  select * from FOOD where FOODID in {select * from LIKES where USERNAME = <username>}; -- not entirely sure if this is correct, I'm just trying to remember the syntax of a subquery
             */

            FoodViewModel[] likedFood = new FoodViewModel[1]; // this is just example code

            return likedFood;
        }

        public static void CreateNewUserInDatabase(string username, string password, string description)
        {
            /*  TODO: run sql query to insert a new user into USER table
             *  query might look like:
             *  insert into USER (USERNAME, PASSWORD, DESCRIPTION) values (<username>, <password>, <description>);
             */
        }

        public static void LikePost(string username, int foodID)
        {
            /*  TODO: run a sql query to insert new like into the LIKES table
             *  query might look like:
             *  insert into LIKES (USERNAME, FOODID) values (<username>, <foodID>);
             */
        }
    }
}

