using System;
using System.Collections;
using System.Data.Entity.Core.Metadata.Edm;

namespace CSharpTestBed
{
    internal class Solution
    {
        public static void printArray<T>(T[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }

        private static void Main(String[] args)
        {
            int[] vInt = new int[] {1, 2, 3};
            string[] vString = new string[] {"Hello", "World"};

            printArray<int>(vInt);
            printArray<string>(vString);
        }
    }
}

