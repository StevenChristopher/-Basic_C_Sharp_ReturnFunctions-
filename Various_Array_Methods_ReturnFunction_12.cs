/* SOURCE:   https://edabit.com/challenge             
 * AUTHOR:   
 * FILENAME: Various_Array_Methods_ReturnFunction_12.cs
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

namespace Various_Array_Methods_ReturnFunction_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 2.54, 254.11, 25.40, 11.254 };
            double[] resultArray = MinMaxLengthAverage(array);
            // TODO Perform appropriate conversion prior to display in Console class
            Console.Write("\nNew Array Values: " + resultArray);

            Console.Write("\n\n<Press Any Key To Exit>");
            Console.ReadLine();
        }

        public static double[] MinMaxLengthAverage(double[] arr)
        {
            double min = arr.Min();
            double max = arr.Max();
            double length = arr.Length;
            double average = arr.Average();
            double[] newArray = { min, max, length, average };
            return newArray;
        }
    }
}
