using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csFinalProject
{
    class Validator
    {
        //I literally just rolled my face on the keyboard here:
        private static Regex uNameRegex = new Regex(@"^[a-zA-Z\d][\w\d]{2}([\w\d]+)");
        private static Regex passwordRegex = new Regex(@"^[\w\d!@#$%^&*()\-+=]{4}([\w\d!@#$%^&*()\-+=]+)$");

        public static bool isValidUsername(string uName)
        {
            return uNameRegex.IsMatch(uName);
        }

        public static bool isValidPassword(string pWord)
        {
            return passwordRegex.IsMatch(pWord);
        }
    }
}