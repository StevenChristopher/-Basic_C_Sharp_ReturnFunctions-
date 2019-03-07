/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Array_Sort_ReturnFunction_13.cs
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

namespace Array_Sort_ReturnFunction_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 25, 5, 2, 254, 54, 4, 11 };
            int[] resultArray = SortNumsAscending(array);
            
            // TODO Perform necessary conversions prior to console display.
            Console.Write("\nSorted Array: " + resultArray);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static int[] SortNumsAscending(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
    }
}
