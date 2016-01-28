using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;

namespace CSharpTestBed
{
    internal class Solution
    {
        class Node
        {
            public Node left, right;
            public int data;
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }



        private static void levelOrder(Node root)
        {
            if (root == null) return;

            Queue<Node> queue = new Queue<Node>();

            queue.Clear();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                Node temp = queue.Dequeue();
                Console.Write(temp.data + " ");
                if (temp.left != null) queue.Enqueue(temp.left);
                if (temp.right != null) queue.Enqueue(temp.right);
            }
        }

        static void Main(String[] args)
        {
            Node root = null;
            int[] tree = new int[6] { 3, 5, 4, 7, 2, 1 };
            for (int i = 0; i < tree.Length; i++)
            {
                root = insert(root, tree[i]);
            }
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    root = insert(root, data);
            //}
            levelOrder(root);

        }
    }
}

