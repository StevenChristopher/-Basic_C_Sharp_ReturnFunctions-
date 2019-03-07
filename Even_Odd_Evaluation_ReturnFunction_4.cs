/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: even_Odd_Evaluation_ReturnFunction_4.cs
 * PURPOSE:           
 * STUDENT:  Steven Christopher
 * DATE:     MAR 01 2019
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

namespace Even_Odd_Evaluation_ReturnFunction_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = IsEvenOrOdd(11);
            Console.Write("\nEvaluation: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static string IsEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
    }
}
