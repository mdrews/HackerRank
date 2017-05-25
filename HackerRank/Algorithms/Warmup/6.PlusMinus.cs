using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -4, 3, -9, 0, 4, 1 };
            List<int> newList = new List<int>(arr);
            int total = arr.Count();
            int positives = arr.Count(x => x > 0);
            int negatives = arr.Count(x => x < 0);
            int zeroes = arr.Count(x => x == 0);

            double positiveRatio = (double)positives / (double)total;
            double negativeRatio = (double)negatives / (double)total;
            double zeroRatio = (double)zeroes / (double)total;
            Console.WriteLine("{0:0.000000}",positiveRatio);
            Console.WriteLine("{0:0.000000}", negativeRatio);
            Console.WriteLine("{0:0.000000}", zeroRatio);

            Console.WriteLine(String.Join(", ", arr));
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}