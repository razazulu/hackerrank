using System;

namespace CSharpTestBed
{
    class Solution {
    
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            char[] seperators = new char[12] { '!', '[', ',', '?', '.', '\\', '_', '\'', '@', '+', ']', ' '};
            string[] res = s.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(res.Length);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
}
}
