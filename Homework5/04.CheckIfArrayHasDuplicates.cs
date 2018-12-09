using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class CheckIfArrayHasDuplicates
    {
        static void Main(string[] args)
        {

            int[] numbers = readIntArrayFromConsole();
            bool has_duplicates = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        has_duplicates = true;
                    }
                }
            }

            Console.WriteLine( (has_duplicates)
                ? "Array has duplicates"
                : "Array has no duplicates");

            Console.ReadKey();
        }

        private static int[] readIntArrayFromConsole()
        {
            Console.WriteLine("Enter number of elements in array:");

            int count = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[count];

            for (int i = 0; i <= count - 1; i++)
            {
                int counter = i + 1;
                Console.WriteLine("Enter array element " + counter);
                var current_number = Convert.ToInt32(Console.ReadLine());
                arr[i] = current_number;
            }

            return arr;
        }
    }
}
