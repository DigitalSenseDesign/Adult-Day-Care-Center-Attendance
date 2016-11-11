using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance
{
    class CommonCode
    {
        public static string ParseBool(bool input, string trueString, string falseString)
        {
            string result = "";

            if (input == true)
            {
                result = trueString;
            }
            else if (input == false)
            {
                result = falseString;
            }
            else
            {
                result = "Error";
            }
            return result;
        }
    }
}
