using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs05
{
    class RemoveDuplicatesString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string to check for duplicates:");
            var str = Console.ReadLine();

            LinkedList<string> strList = new LinkedList<string>();
            strList.AddFirst(str.Substring(0, 1));

            for (int i = 0; i < str.Length; i++)
            {
                if (!strList.Contains(str.Substring(i,1)))
                {
                    strList.AddLast(str.Substring(i, 1));
                }
            }

            Console.Write("New string with duplicates removed: ");
            foreach (var element in strList)
            {
                Console.Write(element);
            }            
            Console.ReadKey();
        }
    }
}
