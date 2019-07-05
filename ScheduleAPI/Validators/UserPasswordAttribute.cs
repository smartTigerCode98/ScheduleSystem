using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ScheduleSystem.ScheduleAPI.Validators
{
    public class UserPasswordAttribute : ValidationAttribute
    {
        private const string Pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,15}$";
        
        public override bool IsValid(object value)
        {
            if (Regex.IsMatch(value.ToString(), Pattern)) return true;
            ErrorMessage =  "Your password must be between 6 characters and 15, have chars in upper and lower cases and also have numbers";
            return false;
        }
    }
}