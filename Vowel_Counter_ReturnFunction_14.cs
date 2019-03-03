/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Vowel_Counter_ReturnFunction_14.cs
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

namespace Vowel_Counter_ReturnFunction_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Contemplation";
            int result = CountVowels(word);
            Console.Write("\nNumber of Vowels: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static int CountVowels(string str)
        {
            char[] name = str.ToCharArray();
            int vowels = 0;


            for (int i = 0; i < name.Length; i++)
            {
                if ((name[i] == 'A' || name[i] == 'E' ||
                      name[i] == 'I' || name[i] == 'O' || name[i] == 'U') ||
                     (name[i] == 'a' || name[i] == 'e' ||
                      name[i] == 'i' || name[i] == 'o' || name[i] == 'u'))
                {
                    vowels = vowels + 1;
                }
            }
            return vowels;
        }
    }
}
