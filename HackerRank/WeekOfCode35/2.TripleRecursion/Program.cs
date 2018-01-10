using System;
using System.Numerics;

namespace _2.TripleRecursion
{
    class Program
    {
        static void tripleRecursion(int n, int m, int k)
        {
            int[,] recursionMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        recursionMatrix[i, j] = m;
                    }
                    else if (i == j)
                    {
                        recursionMatrix[i, j] = recursionMatrix[i - 1, j - 1] + k;
                    }
                    else if (i > j)
                    {
                        recursionMatrix[i, j] = recursionMatrix[i - 1, j] - 1;
                    }
                    else if (i < j)
                    {
                        recursionMatrix[i, j] = recursionMatrix[i, j - 1] - 1;
                    }
                    else
                    {
                        Console.WriteLine("BROKEN");
                    }
                    
                }
            }

            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    Console.Write($"{recursionMatrix[x, y]} ");
                }
                Console.WriteLine("");
            }
        }

        static void Main(string[] args)
        {
            int n = 4;
            int m = 3;
            int k = 1;

            tripleRecursion(n, m, k);
        }
    }
}
