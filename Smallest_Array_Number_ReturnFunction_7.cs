/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Smallest_Array_Number_ReturnFunction_7.cs
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

namespace Smallest_Array_Number_ReturnFunction_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 7.62, 5.56, 2.54, .38, .900 };
            double result = FindSmallestNum(array);
            Console.Write("\nSmallest Number: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static double FindSmallestNum(double[] arr)
        {
            return arr.Min();
        }
    }
}
