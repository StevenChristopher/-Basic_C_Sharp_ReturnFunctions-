/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Number_Fun_ReturnFunction_8.cs
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

namespace Number_Fun_ReturnFunction_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Prompt user for a number.
            int result = AddUp(11);
            Console.Write("\nThe Sum of All Numbers From 0 to 11: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static int AddUp(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num;
                num--;
            }
            return sum;
        }
    }
}
