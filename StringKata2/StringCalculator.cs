using System;

namespace StringKata2
{
    public class StringCalculator
    {
        public int Add(string arg)
        {
            int ats;

            ats = arg == string.Empty ? 0 : int.Parse(arg);


            return ats;
        }
    }
}