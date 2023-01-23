using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        // Test method for sum of array from numbers
        public static long Sum(int[] arr)
        {
            //int sum = arr[0];
            long sum = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                sum += arr[i];
            }
            return sum;
        }

        public static double Average(int[] arr)
        {
            //int sum = arr[0];
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }

        /*public static void Test_SumTwoNumbers()
        {
            if (Sum(new int[] { 1, 2 }) != 3)
            {
                throw new Exception("1+2 != 3");
            }
            else
            {
                Console.WriteLine("Test_SumTwoNumbers Pass");
            }
                
        }*/

    }
}
