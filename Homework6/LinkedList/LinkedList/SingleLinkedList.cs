using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class SingleLinkedList
    {
        private Node First;

        public Node AddFirst(int value)
        {
            Node node = new Node();
            node.Value = value;
            node.Next = null;

            First = node;

            return node;
        }
        public Node AddAfter(Node node, int val)
        {
            Node newNode = new Node();
            newNode.Value = val;
            node.Next = newNode;

            return newNode;
        }

        public bool DetectCycle()
        {
            List<Node> dict = new List<Node>();
            bool is_circular = false;

            Node currentNode = First;

            while (currentNode != null || is_circular)
            {
                if (currentNode.Next != null && dict.Contains(currentNode.Next))
                {
                    is_circular = true;
                    return is_circular;
                }
                else
                {
                    dict.Add(currentNode.Next);
                }

                currentNode = currentNode.Next;
            }

            return is_circular;

        }

        public void Print()
        {
            Node currentNode = First;

            while (currentNode != null)
            {
                Console.Write(currentNode.Value + " ");

                currentNode = currentNode.Next;
            }
        }
    }
}
