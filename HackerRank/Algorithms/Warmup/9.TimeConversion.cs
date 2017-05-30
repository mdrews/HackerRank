using System;
using System.Globalization;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "07:05:45PM";
            DateTime time = DateTime.ParseExact(input, "hh:mm:sstt", CultureInfo.InvariantCulture);
            string result = time.ToString("HH:mm:ss");
            Console.WriteLine(result);
        }
    }
}