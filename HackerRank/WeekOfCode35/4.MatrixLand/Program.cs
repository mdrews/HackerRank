using System;
using System.Globalization;

namespace _4.MatrixLand
{
    class Program
    {
        static void PlusGrid(int n, int m, int[][] A)
        {
            int[][] grid = new int[n][];
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("+");
                    }
                    Console.WriteLine("");
                    
                }
        }
            
        }
        static void Main(string[] args)
        {
            const int n = 4;
            const int m = 5;
            int[][] A = new int[n][];
            A[0] = new[] {1, 2, 3, -1, -2};
            A[1] = new[] {-5, -8, -1, 2, -150};
            A[2] = new[] {1, 2, 3, -250, 100};
            A[3] = new[] {1, 1, 1, 1, 20};

            PlusGrid(n, m, A);
        }
    }
}
