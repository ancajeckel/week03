using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs05
{
    class NthFibonacciNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number <n>:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The <n>th number in Fibonacci series is: " + Fibonacci(number));
            Console.ReadKey();
        }

        public static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
