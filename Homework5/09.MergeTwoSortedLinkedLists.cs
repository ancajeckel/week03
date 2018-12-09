using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    class MergeTwoSortedLinkedLists
    {
        static void Main(string[] args)
        {
            LinkedList<int> my_list1 = new LinkedList<int>();
            my_list1 = InitList(my_list1, 2, 4, 5, 7, 9);
            DisplayList(my_list1);

            Console.WriteLine("");
            LinkedList<int> my_list2 = new LinkedList<int>();
            my_list2 = InitList(my_list2, 1, 6, 8, 10, 11);
            DisplayList(my_list2);

            LinkedList<int> merge_list = new LinkedList<int>();

            int i = 0;
            int j = 0;
            while (i < my_list1.Count || j < my_list2.Count)
            {
                if (i == my_list1.Count)
                {
                    merge_list.AddLast(my_list2.ElementAt(j));
                    j++;
                    continue;
                }
                else if (j == my_list1.Count)
                {
                    merge_list.AddLast(my_list1.ElementAt(i));
                    i++;
                    continue;
                }
                else if (my_list1.ElementAt(i) < my_list2.ElementAt(j))
                {
                    merge_list.AddLast(my_list1.ElementAt(i));
                    i++;
                }
                else
                {
                    merge_list.AddLast(my_list2.ElementAt(j));
                    j++;
                }
            }

            Console.WriteLine("");
            Console.Write("Merged list is: ");
            DisplayList(merge_list);
            Console.ReadKey();
        }

        private static LinkedList<int> InitList(LinkedList<int> list, int v1, int v2, int v3, int v4, int v5)
        {
            list.AddFirst(v1);
            list.AddLast(v2);
            list.AddLast(v3);
            list.AddLast(v4);
            list.AddLast(v5);
            return list;
        }

        private static void DisplayList(LinkedList<int> list)
        {
            foreach (var element in list)
            {
                Console.Write(element + " ");
            }
        }
    }
}
