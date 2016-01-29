using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Globalization;

class Solution
{
    static void Main(String[] args)
    {
        DateTime dtActual = DateTime.ParseExact("6 6 2015"/*Console.ReadLine()*/, "dd mm yyyy", CultureInfo.CreateSpecificCulture("en-GB"));
        //DateTime dtExpected = DateTime.ParseExact("9 6 2015"/*Console.ReadLine()*/, "dd mm yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine(dtActual.Day);
        Console.WriteLine(dtActual.Month);
        Console.WriteLine(dtActual.Year);

        /*int fine = 0;
        if (dtActual > dtExpected)
        {
            if (dtActual.Month == dtExpected.Month)
            {
                fine = 15* (dtActual.Day - dtExpected.Day);
            }
            else if (dtActual.Year != dtExpected.Year)
            {
                fine = 10000;
            }
            //Same year different month
            else
            {
                fine = 500*(dtActual.Month - dtExpected.Month);
            }
        }

        Console.WriteLine(fine);*/
        

     }
}