using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
static class Solution
{

    static int[] solve(int[] grades)
    {
        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] > 35)
            {
                int mod = grades[i] % 5;
                if (mod > 2)
                {
                    grades[i] += 5- mod;
                }
            }
        }
        return grades;
    }

    static void Main(String[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine());
        //int[] grades = new int[n];
        //for (int grades_i = 0; grades_i < n; grades_i++)
        //{
        //    grades[grades_i] = Convert.ToInt32(Console.ReadLine());
        //}
        int[] grades = { 73, 67, 38, 33 };

        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));


    }
}
