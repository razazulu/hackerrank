using System;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace CSharpTestBed
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

    class Solution
    {
        public static Node insert(Node head, int data)
        {
            var node = new Node(data);
            if (head == null)
            {
                //This is the first node make it the head
                return node;
            }

            Node current = head;
            
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = node;
                        
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        static void Main(String[] args)
        {

            Node head = null;
            int T = 4;//Int32.Parse(Console.ReadLine());
            int[] input = new int[] {4, 2, 1, 3};

            for(int i = 0; i < input.Length; i++)
            
            //while (T --> 0)
            {
                int data = input[i];//Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }


}
