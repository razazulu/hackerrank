using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;

namespace CSharpTestBed
{
    internal class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class Solution
    {
        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
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

        public static Node removeDuplicates(Node head)
        {
            if (head == null)
                return head;

            Node cur = head;
            while (cur.next !=null)
            {
                if (cur.data == cur.next.data)
                    cur.next = cur.next.next;
                else
                    cur = cur.next;
            }
            return head;
        }

        private static void Main(String[] args)
        {

            Node head = null;

            int[] tree = new int[6] {1, 2, 2, 3, 3, 4};
            for (int i = 0; i < tree.Length; i++)
            {
                head = insert(head, tree[i]);
            }

            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    head = insert(head, data);
            //}
            head = removeDuplicates(head);
            display(head);
        }

    }

}
    


