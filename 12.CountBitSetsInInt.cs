using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs05
{
    class CountBitSetsInInt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(number, 2);        //convert to its binary representation
            Console.WriteLine(binary);

            int count = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if(binary.Substring(i,1) == "1")
                {
                    count++;
                }
            }

            Console.WriteLine("Count of set bits is: " + count);
            Console.ReadKey();
        }
    }
}
