/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Phone_Number_Format_ReturnFunction_17.cs
 * PURPOSE:           
 * STUDENT:  Steven Christopher
 * DATE:     MAR 01 2019
*/

// STYLE MODIFICATIONS:
// 1) Added a basic console display for the return value.

// FUNCTIONAL MODIFICATIONS:
// 1) Passed integer values into the function.
// 2) Return and display the functions' return value.
// 3) Added Main() method and called in return function.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Number_Format_ReturnFunction_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 1, 2, 3, 8, 6, 7, 5, 3, 0, 9 };
            string result = FormatPhoneNumber(numArray);
            Console.Write("\nResulting Phone Number: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static string FormatPhoneNumber(int[] numbers)
        {
            string result = string.Join("", numbers);
            string area = result.Substring(0, 3);
            string major = result.Substring(3, 3);
            string minor = result.Substring(6);
            string formatted = string.Format("({0}) {1}-{2}", area, major, minor);
            return formatted;
        }
    }
}
