using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;

            for(int x = 1; x <= n; x++)
            {
                for(int a = 0; a < n-x; a++)
                {
                    Console.Write(" ");
                }
                for (int b = 0; b < x; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Hello World!");
        }
    }
}