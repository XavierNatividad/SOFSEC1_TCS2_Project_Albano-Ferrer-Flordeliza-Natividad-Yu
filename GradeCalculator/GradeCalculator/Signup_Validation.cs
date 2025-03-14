using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GradeCalculator
{
    class Signup_Validation
    {
        public int validateUsername(string username)
        {
            if (string.IsNullOrEmpty(username) == false)
            {
                return 0;
            }

            else if (!Regex.IsMatch(username, @"^[\w]+$"))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public int validatePassword(string password, string confirmPassword) 
        {
            if (string.IsNullOrEmpty(password) == false)
            {
                return 0;
            }

            else if (!Regex.IsMatch(password, @"^[\w]+$"))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
