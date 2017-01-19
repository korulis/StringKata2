using System;
using System.Linq;

namespace StringKata2
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (input == string.Empty) return 0;

            var sum = input.Split(new[] { ",", "\n" }, StringSplitOptions.None)
                .Where(s => s != string.Empty)
                .Select(int.Parse)
                .Aggregate(Sum);
            return sum;

        }

        private static int Sum(int s1, int s2)
        {
            return s1 + s2;
        }
    }
}
