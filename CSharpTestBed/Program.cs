using System;
using System.Text;

class Solution
{
    private static void Main(String[] args)
    {
        int n = Int32.Parse(Console.ReadLine());

        while (n -- > 0)
        {
            bool funny = true;
            string pattern = Console.ReadLine();
            if (pattern != null)
            {
                byte[] forwardASCIIValues = Encoding.ASCII.GetBytes(pattern);
                byte[] reverseAsCIIValues = Encoding.ASCII.GetBytes(Reverse(pattern));
                for (int i = 0; i < forwardASCIIValues.Length - 1; i++)
                {
                    if ((byte) Math.Abs(forwardASCIIValues[i] - forwardASCIIValues[i + 1]) !=
                        (byte) Math.Abs(reverseAsCIIValues[i] - reverseAsCIIValues[i + 1])) funny = false;

                }
            }
            if (funny) Console.WriteLine("Funny");
            else Console.WriteLine("Not Funny");
        }
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}