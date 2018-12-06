using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    class RotateArrayByPivot
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 3, 8, 4, 5, 7, 1 };      //for the pivot=8, should look like 4,5,7,1,8,2,3
            Console.Write("Choose a pivot for the array: ");
            writeArray(numbers);

            int pivot = Convert.ToInt32(Console.ReadLine());
            int[] aux = new int[numbers.Length];

            int pivot_index = findPivot(numbers, pivot);
            int current_index = 0;
            
            //add positions after pivot
            for (int i = pivot_index + 1 ; i < numbers.Length; i++)
            {
                aux[current_index] = numbers[i];
                current_index++;
            }

            //add pivot
            aux[current_index] = numbers[pivot_index];
            current_index++;

            //add positions before pivot
            for (int i = 0; i <= pivot_index - 1; i++)
            {
                aux[current_index] = numbers[i];
                current_index++;
            }

            writeArray(aux);
            Console.ReadKey();
        }

        private static int findPivot(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return i;
            }
            throw new ArgumentNullException("Pivot not found");
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
