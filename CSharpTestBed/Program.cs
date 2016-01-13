using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;

namespace CSharpTestBed
{
    class Program
    {
        private static void Main(String[] args)
        {
            //Input
            List<string>input = new List<string>();
            input.Add("1 1 1 0 0 0");
            input.Add("0 1 0 0 0 0");
            input.Add("1 1 1 0 0 0");
            input.Add("0 0 2 4 4 0");
            input.Add("0 0 0 2 0 0");
            input.Add("0 0 1 2 4 0");

            List<List<int>> grid = new List<List<int>>();
            List<int> row;
            
            //Parse input in a 2D list array
            for (int i = 0; i < 6; i++)
            {
                //string input = Console.ReadLine();
                string[] tokens = input[i].Split(' ');
                int[] convertedItems = Array.ConvertAll(tokens, int.Parse);
                row = new List<int>();
                for (int j = 0; j < 6; j++)
                {
                    row.Add(convertedItems[j]);
                }
                grid.Add(row);
            }

            //Calculate the sum of each "hourglass" structure and select the max
            int max = -63; //As in spec
            int sum = 0;
            for (int r = 0; r < 4; r++)
            {
                for (int col = 0; col < 4; col++)
                {
                    sum = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            if (k == 1 && (l == 0 || l == 2)) continue;
                            sum += grid[col + k][r + l];
                        }
                    }
                    if (sum > max) max = sum;
                }
            }
            Console.WriteLine(max);
        }
    }

    
}
