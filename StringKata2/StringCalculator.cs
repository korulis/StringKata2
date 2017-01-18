namespace StringKata2
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == "") return 0;

            var parsedNumber = int.Parse(numbers);

            return parsedNumber;
        }
    }
}
