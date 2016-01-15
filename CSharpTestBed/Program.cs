using System;
using System.Linq;

namespace CSharpTestBed
{
    internal class Difference
    {
        private int [] elements;
        public int maximumDifference;

        public Difference(int[] array)
        {
            elements = new int[array.Length];
            Array.Copy(array, elements, array.Length);
        }

        public void ComputeDifference()
        {
            maximumDifference = elements.Max() - elements.Min();
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.ComputeDifference();

            Console.Write(d.maximumDifference);
        }
    }


}
