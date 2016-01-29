using System;
using System.Collections.Generic;

class Solution
{
    class TestCase
    {
        public int students;
        public int cancellationThresh;
        public List<int> arrivalTimes = new List<int>();

        public TestCase(string input1, string input2)
        {
            string[] tokens = input1.Split(' ');
            int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
            students = convertedItems[0];
            cancellationThresh = convertedItems[1];

            tokens = null;
            convertedItems = null;

            tokens = input2.Split(' ');
            convertedItems = Array.ConvertAll(tokens, int.Parse);

            for (int i = 0; i < students; i++)
            {
                arrivalTimes.Add(convertedItems[i]);
            }

        }
    }

    private static void Main(String[] args)
    {
        List<TestCase> testCases = new List<TestCase>();
        List<string> output = new List<string>();
        //var num_tests = Console.ReadLine();
        //output.Add(num_tests);
        //int t = Int32.Parse(num_tests);

        testCases.Add(new TestCase("3 2", "-1 0 1"));
        /*while (t -- > 0)
        {
            string inputLine1 = Console.ReadLine();
            output.Add(inputLine1);
            string inputLine2 = Console.ReadLine();
            output.Add(inputLine2);
            testCases.Add(new TestCase(inputLine1, inputLine2));
        }*/

        //Print the input
        foreach(string s in output)Console.WriteLine(s);
        //Test the test cases and print output
        foreach (TestCase test in testCases)
        {
            if(ClassCancelled(test))Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }

    static bool ClassCancelled(TestCase test)
    {
        int studentsPresent = 0;
        for (int i = 0; i < test.students; i++)
        {
            if (test.arrivalTimes[i] <= 0) studentsPresent++;
        }
        return studentsPresent < test.cancellationThresh;
    }
}