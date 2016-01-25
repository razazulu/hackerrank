using System;
using System.Collections;
using System.Data.Entity.Core.Metadata.Edm;

namespace CSharpTestBed
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

    internal class Solution
    {
        private static int getHeight(Node root)
        {
            if (root == null) return 0;
            return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
        }

        private static Node insert(Node root, int data)
        {
            if (root == null) return new Node(data);

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

        private static void Main(String[] args)
        {
            Node root = null;
            int T = 3/*12*/;//Int32.Parse(Console.ReadLine());
            int[] tree = new int[7] {3,5,2,1,4,6,7};
            for (int i = 0; i < tree.Length; i++)
            {
                root = insert(root, tree[i]);
            }
            
            /*while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }*/
            int height = getHeight(root);
            Console.WriteLine(height);
        }
    }
}

