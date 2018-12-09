using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs05
{
    class SumDigitsOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number with more digits:");
            var input_str = Console.ReadLine();

            int sum = SumDigits(input_str, input_str.Length);
            Console.WriteLine(sum);

            Console.ReadKey();
        }

        public static int SumDigits(string str, int str_length)
        {
            if (str_length == 1)
            {
                return Convert.ToInt32(str.Substring(0, 1));
            }
            else
            {
                int digit = Convert.ToInt32(str.Substring(str_length - 1, 1));
                return digit + SumDigits(str, str_length - 1);
            }
        }
    }
}
