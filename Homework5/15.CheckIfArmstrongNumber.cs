using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs05
{
    class CheckIfArmstrongNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check if Armstrong number:");
            var input_str = Console.ReadLine();
            int number = Convert.ToInt32(input_str);

            double sum_powers = 0;
            int current = number;
            for (int i = 0; i < input_str.Length; i++)
            {
                //get current digit from number
                var digit = current % 10;
                current = current / 10;
                sum_powers = sum_powers + Math.Pow((double)digit, 3);
            }

            Console.WriteLine( ((double)number == sum_powers)
                ? "Number is an Armstrong!"
                : "Number is NOT an Armstrong!");

            Console.ReadKey();
        }
    }
}
