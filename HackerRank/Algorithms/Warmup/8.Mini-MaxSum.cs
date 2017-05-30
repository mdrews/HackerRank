using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace _8.Mini_MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr_temp = { "34523452345", "234523452435", "452452345", "4524523454534" };
            BigInteger[] arr = Array.ConvertAll(arr_temp, Int64.Parse);
            Array.Sort(arr);
            int number = arr.Length;
            BigInteger sumA = arr[0] + arr[1] + arr[2] + arr[3];
            BigInteger sumB = (long)arr[number - 1] + (long)arr[number - 2] + (long)arr[number - 3] + (long)arr[number - 4];
            Console.WriteLine("{0} {1}", sumA, sumB);
        }
    }
}