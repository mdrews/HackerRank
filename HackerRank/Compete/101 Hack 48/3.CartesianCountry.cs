using System;

namespace _2.CartesianCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_x1 = { "1", "1" };//Console.ReadLine().Split(' ');
            long x1 = Convert.ToInt64(tokens_x1[0]);
            long y1 = Convert.ToInt64(tokens_x1[1]);
            string[] tokens_x2 = { "5", "4" };//Console.ReadLine().Split(' ');
            long x2 = Convert.ToInt64(tokens_x2[0]);
            long y2 = Convert.ToInt64(tokens_x2[1]);
            string[] tokens_xC = { "2", "3" };//Console.ReadLine().Split(' ');
            long xC = Convert.ToInt64(tokens_xC[0]);
            long yC = Convert.ToInt64(tokens_xC[1]);
            long total = 0;
            long xResult = (xC - x1 <= x2 - xC) ? (xC - x1) : (x2 - xC);
            long yResult = (yC - y1 <= y2 - yC) ? (yC - y1) : (y2 - yC);
            //if (xResult % 2 == 0) xResult -= 1;
            //if (yResult % 2 == 0) yResult -= 1;
            long xTotal = ((xResult * 2) + 1);
            long yTotal = ((yResult * 2) + 1);
            total = ((xTotal * yTotal) / 2);
            Console.WriteLine(total);
        }
    }
}