using System;
using System.Linq;

namespace StringKata2
{
    public class StringCalculator
    {
        public int Add(string arg)
        {
            if (arg == string.Empty) return 0;

            var strings = arg.Split(',').ToList();
            int sum = 0;
            var parsed =  strings.Select(int.Parse).ToList();

            foreach (var i in parsed)
            {
                sum += i;
            }

            return sum;
        }

    }
}