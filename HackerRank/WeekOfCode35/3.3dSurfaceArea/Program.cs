using System;
using System.ComponentModel;

namespace _3._3dSurfaceArea
{
    class Program
    {
        static int surfaceArea(int H, int W, int[][] A)
        {
            int total = 0;
            for (int i = 0; i < H; i++)
            {
                int lineTotal = 0;
                for (int j = 0; j < W; j++)
                {
                    if (j == 0)
                    {
                        lineTotal += A[i][j];
                    }
                    else
                    {
                        lineTotal += Math.Abs(A[i][j] - A[i][j - 1]);
                    }
                    if (j == W-1)
                    {
                        lineTotal += Math.Abs(A[i][j]);
                    }
                }
                total += lineTotal;
            }
            for (int j = 0; j < W; j++)
            {
                int lineTotal = 0;
                for (int i = 0; i < H; i++)
                {
                    if (i == 0)
                    {
                        lineTotal += A[i][j];
                    }
                    else
                    {
                        lineTotal += Math.Abs(A[i][j] - A[i-1][j]);
                    }
                    if (i == H - 1)
                    {
                        lineTotal += Math.Abs(A[i][j]);
                    }
                }
                total += lineTotal;
            }
            total = total + (H * W * 2);
            return total;
        }

        static void Main(string[] args)
        {
            const int H = 3;
            const int W = 3;
            int[][] B = new int[H][];
            B[0] = new[] { 1, 3, 4 };
            B[1] = new[] { 2, 2, 3 };
            B[2] = new[] { 1, 2, 4 };
            int[,] A = new int[H, W];
            
            int result = surfaceArea(H, W, B);
            Console.WriteLine(result);
        }
    }
}
