using System;
using System.Linq;

namespace _1.BalancedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int[] a = { 20,10 };

            int sumLeft = 0;
            int sumRight = 0;
            for(int x = 0; x < n/2; x++)
            {
                sumLeft += a[x];
            }
            for (int y = n/2; y < n; y++)
            {
                sumRight += a[y];
            }

            Console.WriteLine(Math.Abs(sumRight-sumLeft));
        }
    }
}