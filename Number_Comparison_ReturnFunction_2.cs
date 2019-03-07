/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Number_Comparison_ReturnFunction_2.cs
 * PURPOSE:           
 * STUDENT:  Steven Christopher
 * DATE:     MAR 02 2019
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

namespace Number_Comparison_ReturnFunction_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = LessThanOrEqualToZero(-2.54);
            Console.Write("\nBoolean Evaluation: " + result);

            Console.Write("\n\n<Press Ant Key To Exit>");
            Console.ReadLine();
        }

        public static bool LessThanOrEqualToZero(double a)
        {
            if (a <= 0)
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
