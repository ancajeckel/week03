using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs05
{
    class FindMajorityNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 4, 8, 3, 6, 7, 3, 3, 2, 3 };
            Console.WriteLine("Array to search number holding majority: {3,4,8,3,6,7,3,3,2,3}");

            int max_occurr = 0;
            int majority_index = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                int occurrences = 0;
                foreach (var elem in numbers)
                { 
                    if (numbers[i] == elem)
                    occurrences++;
                }
                if (occurrences > max_occurr)
                {
                    max_occurr = occurrences;
                    majority_index = i;
                }
            }

            Console.WriteLine("Majority number is: " + numbers[majority_index]);
            Console.ReadKey();
        }
    }
}
