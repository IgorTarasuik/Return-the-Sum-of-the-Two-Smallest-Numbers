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
            int[] check = { 2, 9, 6, -1 };
            SumSmallest(check);

        }

        public static int SumSmallest(int[] values)
        {

            //changes
            IEnumerable<int> resultPositive = values.Where(i => i >= 0);
            int[] resultFiltered = resultPositive.OrderBy(i => i).ToArray();
            int resultFinal = resultFiltered[0] + resultFiltered[1];
            return resultFinal; 
        }
        int hello;
          
    }

   
}
