/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Remove_Odd_Numbers_ReturnFunction_18.cs
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

namespace Remove_Odd_Numbers_ReturnFunction_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 1, 2, 5, 4, 11, 22, 10, 13, 12 };
            int[] resultArray = NoOdds(numArray);
            string result = string.Join(" ", resultArray);
            Console.Write("\nEven Number Array: " + result);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static int[] NoOdds(int[] arr)
        {
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr[j] = arr[i];
                    j++;
                }
            }

            int[] temp = new int[j];

            for (int k = 0; k < j; k++)
            {
                temp[k] = arr[k];
            }

            return temp;
        }
    }
}
