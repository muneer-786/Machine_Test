using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechinetest
{
   

    class test
    {
        //Funtion for max sum
        static int SubarraySum(int[] ar)
        {
            if (ar == null || ar.Length == 0)
                return 0;

            //maximum sum =ms
            //current sum=cs

            int ms = ar[0]; // Stores the maximum sum found so far
            int cs = ar[0]; // Tracks the sum of the current subarray

            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] > cs + ar[i])
                    cs = ar[i];
                else
                    cs = cs + ar[i];

                if (cs > ms)
                    ms = cs;
            }

            return ms;
        }

        static void Main()
        {
            Console.WriteLine("Enter the number of array elements:");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer for the number of array elements:");
            }

            int[] ar = new int[n];                             //Array Declaratuin
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n; i++)                        //Reading Elements
            {
                int e;
                while (!int.TryParse(Console.ReadLine(), out e))
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer for element at index " + i + ":");
                }
                ar[i] = e;
            }

            int mSum = SubarraySum(ar);
            Console.WriteLine("Maximum sum of any contiguous subarray: " + mSum);
            Console.Read();
        }
    }
}

