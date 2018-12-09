using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    class ReverseLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<int> my_list = new LinkedList<int>();
            my_list = InitList(my_list, 2, 4, 5, 7, 9);
            DisplayList(my_list);
            Console.WriteLine("");

            LinkedList<int> aux = new LinkedList<int>();
            LinkedListNode<int> current_node = my_list.Last;      //start from last node in my list

            while (current_node != null)                          //go through the list
            {
                aux.AddLast(current_node.Value);                  //add to the end of the new list
                current_node = current_node.Previous;             //loop through the list from the end to the front
            }

            DisplayList(aux);
            Console.ReadKey();
        }

        public static LinkedList<int> InitList(LinkedList<int> list, int v1, int v2, int v3, int v4, int v5)
        {
            list.AddFirst(v1);
            list.AddLast(v2);
            list.AddLast(v3);
            list.AddLast(v4);
            list.AddLast(v5);
            return list;
        }

        public static void DisplayList(LinkedList<int> list)
        {
            foreach (var element in list)
            {
                Console.Write(element + " ");
            }
        }
    }
}
