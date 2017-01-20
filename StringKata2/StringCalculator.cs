using System;
using System.Linq;

namespace StringKata2
{
    public class StringCalculator
    {
        private readonly string[] _initialDelimiters = { ",", "\n" };
        private const string OptionsMarker = "//";

        public int Add(string input)
        {
            if (input == string.Empty) return 0;

            var pureInput = input;
            var delimiters = _initialDelimiters.ToArray();


            if (input.StartsWith(OptionsMarker))
            {
                pureInput = ExtractDelimitedNumbers(input);
                delimiters = UpdateDelimiters(input, delimiters);
            }


            var sum = SumNumbers(pureInput, delimiters);
            return sum;

        }

        private string ExtractDelimitedNumbers(string input)
        {
            var i = input.IndexOf("\n", StringComparison.Ordinal);

            var pureInput = input.Substring(i + 1);
            return pureInput;
        }

        private string[] UpdateDelimiters(string input, string[] delimiters)
        {
            var i = input.IndexOf("\n", StringComparison.Ordinal);

            var optionDelimiter = input.Substring(0, i + 1).TrimEnd('\n').TrimStart('/');
            delimiters = _initialDelimiters.With(optionDelimiter);
            return delimiters;
        }

        private static int SumNumbers(string delimitedNumbers, string[] delimiters)
        {
            return delimitedNumbers.Split(delimiters, StringSplitOptions.None)
                .Where(s => s != string.Empty)
                .Select(int.Parse)
                .Aggregate(Sum);
        }

        private static int Sum(int s1, int s2)
        {
            return s1 + s2;
        }
    }
}
