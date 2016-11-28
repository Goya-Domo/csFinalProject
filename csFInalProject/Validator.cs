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
        private static Regex uNameRegex = new Regex(@"^[a-zA-Z\d][\w\d]{2}([\w\d]+)");
        private static Regex passwordRegex = new Regex(@"barf");
        public static bool isValidUsername(string uName)
        {
            if (uNameRegex.IsMatch(uName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isValidPassword()
        {
            return false;
        }
    }
}
