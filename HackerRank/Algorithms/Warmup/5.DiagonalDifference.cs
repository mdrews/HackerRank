using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine());
        //int[][] a = new int[n][];
        //for (int a_i = 0; a_i < n; a_i++)
        //{
        //    string[] a_temp = Console.ReadLine().Split(' ');
        //    a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
        //}
        int n = 3;
        int[][] a = new int[][] { new int[]{ 11, 2, 4 }, new int[] { 4, 5, 6 }, new int[]{ 10, 8, -12 } };
        int suma = 0;
        int sumb = 0;
        int sumTotal = 0;
        for (int x = 0; x < n; x++)
        {
            suma += a[x][x];
            sumb += a[x][(n - x)-1];
        }
        Console.WriteLine(suma);
        Console.WriteLine(sumb);
        sumTotal = Math.Abs(suma - sumb);
        Console.WriteLine(sumTotal);
        Console.ReadLine();
    }
}
