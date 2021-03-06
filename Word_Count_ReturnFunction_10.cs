/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Word_Count_ReturnFunction_10.cs
 * PURPOSE:           
 * STUDENT:  Steven Christopher
 * DATE:     MAR 03 2019
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

namespace Word_Count_ReturnFunction_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Somewhere, out there, exists my precious number";
            int result = CountWords(sentence);
            Console.Write("\nCount: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static int CountWords(string str)
        {
            string[] words = str.Split(' ');
            return words.Length;
        }
    }
}
