/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Name_Reversal_ReturnFunction_16.cs
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

namespace Name_Reversal_ReturnFunction_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = NameShuffle("Ariana Grande");
            Console.Write("\nNew Name: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static string NameShuffle(string str)
        {
            string[] words = str.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
