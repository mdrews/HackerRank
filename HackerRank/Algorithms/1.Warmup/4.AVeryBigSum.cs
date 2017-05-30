using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine());
        //string[] arr_temp = Console.ReadLine().Split(' ');
        //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        int[] arr = new int[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
        double sum = 0;
        foreach(var number in arr)
        {
            sum += number;
        }
        Console.WriteLine("Sum is: {0}", sum);
    }
}
