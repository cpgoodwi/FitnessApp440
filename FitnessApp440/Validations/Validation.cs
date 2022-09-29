using System;
using System.Text.RegularExpressions;

using static FitnessApp440.Models.UserViewModel;
namespace FitnessApp440.Validations
{
    // This is a validation class that will be used to validate the entry from the user.
    public class Validation
    {
        // This method checks to see if the ussername has 20 characters
        public bool IsUserNameLengthValid(string password)
        {
            return String.IsNullOrEmpty(password) || password.Length <= 20;

        }

        // This method checks to see if the ussername has 100 characters
        public bool IsImageStringValid(string password)
        {
            return String.IsNullOrEmpty(password) || password.Length <= 100;

        }

        // This method checks to see if the password has 40 characters
        public bool IsPasswordLengthValid(string password)
        {
            return String.IsNullOrEmpty(password) || password.Length <= 40;

        }

        // This method checks to see if the text text are strings. This validation can be used multiples times
        public bool IsTextValid(string text)
        {
            return String.IsNullOrEmpty(text);

        }

        // This method is a regex that validates the passwords the user inputs.
        public bool IsPasswordValid(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum8Chars.IsMatch(password);

            return true;
        }
        
    }
}

