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
        private static Regex passwordRegex = new Regex(@"^[\w\d!@#$%^&*()\-+=]{5}([\w\d!@#$%^&*()\-+=]+)$");

        public static bool IsValidUsername(string uName)
        {
            return uNameRegex.IsMatch(uName) && uName.Length <= 32;
        }

        public static bool IsValidPassword(string pWord)
        {
            return passwordRegex.IsMatch(pWord) && pWord.Length <= 32;
        }

        public static bool IsValidId(int id)
        { return IsValidId(id.ToString()); }

        public static bool IsValidId(string id)
        {
            bool valid = true;
            for (int ndx = 0; ndx < id.Length; ndx++)
            {
                if (!char.IsDigit(id[ndx]))
                {
                    valid = false;
                    break;
                }
            }

            return valid;
        }
    } 
}