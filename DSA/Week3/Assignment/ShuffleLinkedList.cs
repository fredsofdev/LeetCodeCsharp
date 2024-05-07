using DSA.Week2.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week3.Assignment
{
    internal class ShuffleLinkedList
    {
        public static Node ShuffleNodes(Node head)
        {
            int count = 0;
            Node? current = head;
            while(current != null)
            {
                count++;
                current = current.next;
            }
            
            Node[] wrapper = new Node[count];
            current = head;
            for(int i = 0; i < wrapper.Length; i++)
            {
                wrapper[i] = current;
                current = current.next;
            }

            Shuffle.shuffle(wrapper);
            
            Node holder = new Node();
            current = holder;
            for(int i = 0;i< wrapper.Length; i++)
            {
                current.next = wrapper[i];
                current = current.next;
            }
            current.next = null;
            
            return holder.next;
        }

        public static void Run()
        {
            Console.WriteLine("Shuffle Linkedlist");
            Node head = new Node();
            Node? current = head;
            Console.Write("Before shuffling: ");
            for (int i = 0; i < 10; i++)
            {
                Node newNode = new Node();
                newNode.value = i;
                current.next = newNode;
                current = current.next;
                Console.Write(i + " ");
            }

            
            Console.WriteLine();
            Console.Write("After shuffling: ");
            current = ShuffleNodes(head.next);
            while (current != null)
            { 
                Console.Write(current.value + " "); 
                current = current.next;
            }
            Console.WriteLine();
        }
    }

    class Node : IComparable
    {
        public int value { get; set; }
        public Node? next { get; set; }

        public int CompareTo(object? obj)
        {
            Node other = obj as Node;
            if (value > other.value) return 1;
            if (value < other.value) return -1;
            return 0;
        }
    }
}
