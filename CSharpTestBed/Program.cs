using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        //int T = Int32.Parse(Console.ReadLine());
        //while (T-- > 0)
        int[] input = new int[3] {12, 5, 7};
        for(int i = 0; i < input.Length; i++)
        {
            //string test = Console.ReadLine();
            if (IsPrime(input[i])) Console.WriteLine("Prime");
            else Console.WriteLine("Not prime");
        }
    }

    private static bool IsPrime(int input)
    {
        int boundary = (int) Math.Floor(Math.Sqrt(input));

        if (input == 1) return false;
        if (input == 2) return true;

        for (int i = 2; i <= boundary; ++i)
        {
            if (input % i == 0) return false;
        }

        return true; 
    }
}