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
//<<<<<<< HEAD
        private static Regex passwordRegex = new Regex(@"barf");
/*=======
        private static Regex passwordRegex = new Regex(@"assword");
>>>>>>> c3be890b7c8783ce4139e1f463cf1f29cee03631*/
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
