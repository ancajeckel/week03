using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs05
{
    class RemoveDuplSortedLinkedList
    {
        static void Main(string[] args)
        {
            var myList = InitList();
            DisplayList(myList);

            for (int i = 0; i < myList.Count - 1; i++)
            {
                var firstElem = myList.ElementAt(i);
                var secondElem = myList.ElementAt(i + 1);
                if (firstElem == secondElem)
                {
                    myList.Remove(firstElem);
                }
            }

            DisplayList(myList);
            Console.ReadKey();
        }

        private static LinkedList<int> InitList()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(30);
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
