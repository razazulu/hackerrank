using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTestBed
{
    class Solution
    {
        private static void Main(String[] args)
        {
            //Read input
            int a = Convert.ToInt32(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            
            
            //This algorithm crashes one of the test cases?
            //1. sort the array
            /*int key = 0;
            int j = 0;

            for (int i = 0; i < input.Length; i++)
            {
                key = input[i];
                j = i - 1;
                while (j >= 0 && key < input[j])
                {

                    input[j + 1] = input[j];
                    j--;
                }
                input[j + 1] = key;
            }*/
            Array.Sort(input);

            //Find the minimum absolute difference of pairs in this list
            //int key = 0;
            //int j = 0;
            int min = (int) Math.Pow(10, 7);

            for (int i = 0; i < input.Length - 1; i++)
            {
                int res = Math.Abs(input[i + 1] - input[i]);
                if (res < min) min = res;
            }

            //Find the pairs that correspond to the min difference
            List<string> output = new List<string>();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if ((Math.Abs(input[i + 1] - input[i])) == min)
                {
                    output.Add(input[i].ToString() + " " + input[i+1].ToString());
                }
            }

            foreach (string s in output)
            {
                Console.WriteLine(s);
            }
        }
    }
}
