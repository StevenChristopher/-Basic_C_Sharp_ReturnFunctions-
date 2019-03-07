/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Largest_Array_Number_ReturnFunction_6.cs
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

namespace Largest_Array_Number_ReturnFunction_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 8, 10, 7, 11, 9 };
            int result = FindLargestNum(array);
            Console.Write("\nLargest Array Value: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static int FindLargestNum(int[] arr)
        {
            return arr.Max();
        }

    }
}
