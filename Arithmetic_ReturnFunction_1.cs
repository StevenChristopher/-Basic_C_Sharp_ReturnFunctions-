/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Arithmetic_ReturnFunction_1.cs
 * PURPOSE:  Create a function that solves a mathematical expression and returns that
 *           value. Call the function from Main() and display the results.
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

namespace Arithmetic_ReturnFunction_1
{
    class Program
    {
        static void Main()
        {
            int result = Sum(200, 54);
            Console.Write("\nReturn Value: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
