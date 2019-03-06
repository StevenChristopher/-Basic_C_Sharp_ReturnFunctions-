/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Remove_Odd_Numbers_v2_ReturnFunction_19.cs
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

namespace Remove_Odd_Numbers_v2_ReturnFunction_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 1, 2, 5, 4, 11, 22, 13, 10, 12 };
            int[] resultArray = NoOdds(numArray);
            string result = string.Join(" ", resultArray);
            Console.Write("\nEven Number Array: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static int[] NoOdds(int[] arr)
        {
            return arr.Where(n => n % 2 == 0).ToArray();
        }
    }
}
