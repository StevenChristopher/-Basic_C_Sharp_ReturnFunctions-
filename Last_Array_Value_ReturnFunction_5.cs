/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Last_Array_Value_ReturnFunction_5.cs
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

namespace Last_Array_Value_ReturnFunction_5
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] array = new object[] { 7, 8, 9, 10, 11 };
            object result = GetLastItem(array);
            Console.Write("\nLast Item in Array: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static object GetLastItem(object[] arr)
        {
            return arr.Last();
        }
    }
}
