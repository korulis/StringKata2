using System.Linq;

namespace StringKata2
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == "") return 0;

            var numbersList = numbers.Split(',');

            var sum = numbersList.ToList().Select(int.Parse).Aggregate((s1, s2) => s1 + s2);

            return sum;
        }
    }
}
