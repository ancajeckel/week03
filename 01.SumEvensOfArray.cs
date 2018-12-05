using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class SumEvensOfArray
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 5, 8, 16, 20 };

            Console.WriteLine("Sum of even elements of array is: " + sum_evens(numbers));

            Console.ReadKey();
        }

        public static int sum_evens(int[] arr)
        {
            int sum = 0;
            foreach (var element in arr)
            {
                if (element % 2 == 0)
                {
                    sum = sum + element;
                }
            };
            return sum;
        }
    }
}
