/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: String_Comparison_ReturnFunction_9.cs
 * PURPOSE:           
 * STUDENT:  Steven Christopher
 * DATE:     MAR 03 2019
*/

// STYLE MODIFICATIONS:
// 1) Added console display messaging and prompts.
// 2) Added output display.

// FUNCTIONAL MODIFICATIONS:
// 1) Passed specific values into the function.
// 2) Return and display the functions' return value.
// 3) Added Main() method and called in return function.
// 4) Added program exit.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Comparison_ReturnFunction_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Witchcraft";
            string string2 = "craft";
            bool result = CheckEnding(string1, string2);
            Console.Write("\nEvaluation: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static bool CheckEnding(string str1, string str2)
        {
            if (str1.EndsWith(str2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
