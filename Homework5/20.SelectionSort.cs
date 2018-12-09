using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 9, 3, 8, 4, 5, 7, 2 };
            writeArray(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                int min_index = i;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[min_index])
                    {
                        min_index = j;
                    }
                }
                swapArray(numbers, i, min_index);
            }

            Console.WriteLine("Array sorted through Selection sort:");
            writeArray(numbers);
            Console.ReadKey();
        }

        public static void swapArray(int[] arr, int pos1, int pos2)
        {
            int temp = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = temp;
        }

        public static void writeArray(int[] arr)
        {
            Console.Write("{");
            for (int i = 0;i < arr.Length;i++)
	        {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i] + "}");
                }
                else
                {
                    Console.Write(arr[i] + ",");
                }
	        }
            Console.WriteLine();
        }
    }
}
