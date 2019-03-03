/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Absolute_Sum_ReturnFunction_11.cs
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

namespace Absolute_Sum_ReturnFunction_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { -7, 10, -11, 9, 8 };
            int result = GetAbsSum(array);
            Console.Write("\nAbsolute Sum of Array: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static int GetAbsSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += Math.Abs(arr[i]);
            }
            return sum;

        }
    }
}
