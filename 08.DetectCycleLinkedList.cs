using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    class DetectCycleLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<int> my_list = new LinkedList<int>();
            my_list = InitList(my_list, 1, 2, 3, 4, 5, 3, 4, 5);    //circular list
            DisplayList(my_list);
            DisplayMessage(CheckIfCircular(my_list));

            my_list = InitList(my_list, 1, 2, 3, 4, 5, 6, 7, 8);    //not-circular list
            DisplayList(my_list);
            DisplayMessage(CheckIfCircular(my_list));

            Console.ReadKey();
        }

        public static bool CheckIfCircular(LinkedList<int> list)
        {
            LinkedList<int> copy = list;
            LinkedListNode<int> current_node = list.First;
            int i = 0;

            //go through the list
            while (current_node != null)
            {
                current_node = current_node.Next;
                i++;

                //go through a shadow list until previous element
                LinkedListNode<int> comp_node = copy.First;
                int j = 0;
                while (comp_node != null && current_node != null)
                {
                    if (j == i)
                    {
                        break;
                    }
                    if (current_node.Value == comp_node.Value)
                    {
                        return true;
                    }
                    comp_node = comp_node.Next;
                    j++;
                }
            }
            return false;
        }

        public static LinkedList<int> InitList(LinkedList<int> list, int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8)
        {
            list.Clear();
            list.AddFirst(v1);
            list.AddLast(v2);
            list.AddLast(v3);
            list.AddLast(v4);
            list.AddLast(v5);
            list.AddLast(v6);
            list.AddLast(v7);
            list.AddLast(v8);
            return list;
        }

        public static void DisplayList(LinkedList<int> list)
        {
            foreach (var element in list)
            {
                Console.Write(element + " ");
            }
        }

        public static void DisplayMessage(bool checkResult)
        {
            Console.WriteLine("");
            Console.WriteLine(checkResult
                ? "List is circular"
                : "List is not circular");
        }
    }
}
