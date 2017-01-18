using System;
using System.Linq;

namespace StringKata2
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == "") return 0;

            var sum = numbers
                .Split(new[] { "\'\\r\\n\'", "," }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .Select(int.Parse)
                .Aggregate((s1, s2) => s1 + s2);

            return sum;
        }
    }
}
