/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Date_Evaluation_ReturnFunction_3.cs
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

namespace Date_Evaluation_ReturnFunction_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = OurWeddingAnniversary(2019, 04, 08);
            Console.Write("\nBoolean Result: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static bool OurWeddingAnniversary (int year, int month, int day)
        {
            if (month == 04 && day == 08)
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
