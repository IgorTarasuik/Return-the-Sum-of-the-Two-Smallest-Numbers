using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] check = { 2, 9, 6, -1 };
            // SumSmallest(check);// Return the Sum of the Two Smallest Numbers

            //Reverse("Andrey"); // reverse string 
        }

        public static int SumSmallest(int[] values)
        {


            IEnumerable<int> resultPositive = values.Where(i => i >= 0); // get possitive results from values. 
            int[] resultFiltered = resultPositive.OrderBy(i => i).ToArray(); // ordering numbers in asc order
            int resultFinal = resultFiltered[0] + resultFiltered[1];
            return resultFinal;
        }

        public static string Reverse(string str)
        {
            string reversedString = new string(str.Reverse().ToArray()); // reverse string 
            return reversedString;
        }
    }

   
}
