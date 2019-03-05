/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: String_Evaluations_ReturnFunction_15.cs
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

namespace String_Evaluations_ReturnFunction_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = VerifySubstrs("Programming", "Pro", "gram", "ming");
            Console.Write("\nEvaluation Result: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static string VerifySubstrs(string mainStr, string head, string body, string tail)
        {
            if (mainStr.StartsWith(head) && mainStr.Contains(body) && mainStr.EndsWith(tail))
            {
                return "Checks Complete.";
            }
            else
            {
                return "Incomplete Word.";
            }

        }
    }
}
