using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class ComputeCompareFactorial
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number <n> to compute <n!>");
            int number = Convert.ToInt32(Console.ReadLine());
            DateTime time0 = DateTime.Now;      //start timer

            long fact1 = iterativeFactorial(number);
            Console.WriteLine(fact1);
            var timer = DateTime.Now.Subtract(time0);
            Console.WriteLine("Executed in " + DateTime.Now.Subtract(time0));

            long fact2 = recursiveFactorial(number);
            Console.WriteLine(fact2);
            Console.WriteLine("Executed in " + DateTime.Now.Subtract(time0));

            Console.ReadKey();
        }

        private static long recursiveFactorial(int nr)
        {
            if (nr == 1)
            {
                return (long)1;
            }
            else
            {
                return (long)nr * recursiveFactorial(nr - 1);
            }
        }

        public static long iterativeFactorial(int nr)
        {
            long fact = 1;
            for (int i = 1; i <= nr; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
