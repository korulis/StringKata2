using System.Linq;

namespace StringKata2
{
    public static class ArrayExtensions
    {
        public static string[] With(this string[] initial, string newElement)
        {
            var temp = initial.ToList();
            temp.Add(newElement);
            return temp.ToArray();
        }
    }
}