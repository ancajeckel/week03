using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs05
{
    class ThirdElementFromEndList
    {
        static void Main(string[] args)
        {
            var myList = InitList();
            DisplayList(myList);

            Console.WriteLine("Third element from end is: " + myList.ElementAt(myList.Count - 3));

            Console.ReadKey();
        }

        private static LinkedList<int> InitList()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(10);
            list.AddLast(20);
            list.AddLast(25);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);

            return list;
        }

        public static void DisplayList(LinkedList<int> list)
        {
            foreach (var node in list)
            {
                Console.Write(node + " ");
            }
            Console.WriteLine("");
        }
    }
}
