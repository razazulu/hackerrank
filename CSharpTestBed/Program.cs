using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTestBed
{
    class Calculator
    {
        public Calculator()
        {

        }

        public int Power(int n, int p)
        {
            if(n < 0 || p < 0)throw new Exception("n and p should be non-negative");
            return (int)Math.Pow(n, p);
        }
    }

    class Solution
    {
        static void Main(String[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);

                try
                {
                    int ans = myCalculator.Power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
