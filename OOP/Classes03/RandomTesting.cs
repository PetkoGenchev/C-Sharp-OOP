using System;
using System.Collections.Generic;
using System.Text;

namespace Classes03
{
    public class RandomTesting
    {
        public static double CalculateDays(int[] input, int[] input2)
        {
            DateTime first = new System.DateTime(input[0], input[1], input[2]);
            DateTime second = new System.DateTime(input2[0], input2[1], input2[2]);

            TimeSpan result = first.Subtract(second);

            var resultingStuff = Math.Abs(result.TotalDays);
            return resultingStuff;
        }
    }
}
