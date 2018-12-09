using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class CheckTwoStringsIfAnagrams
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first string:");
            char[] arr1 = CreateSortedArray(Console.ReadLine());

            Console.WriteLine("Please enter second string:");
            char[] arr2 = CreateSortedArray(Console.ReadLine());

            if (CompareTwoArrays(arr1, arr2) == true)
            {
                Console.WriteLine("The two strings are anagrams!");
            }
            else
            {
                Console.WriteLine("The two strings are not anagrams!");
            }

            Console.ReadKey();
        }

        public static char[] CreateSortedArray(string inputString)
        {
            char[] arr;
            arr = inputString.ToCharArray();
            Array.Sort(arr);

            return (arr);
        }

        public static bool CompareTwoArrays( char[] firstArray, char[] secondArray)
        {
            if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }        
        }
    }
}
