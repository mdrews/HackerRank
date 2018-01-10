using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace arrays_ds
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader testcase1 = new StreamReader("TestCases\\1.txt"))
            {
                    int n = Convert.ToInt32(testcase1.ReadLine());
                    string[] arr_temp = testcase1.ReadLine().Split(' ');
                    int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

                PrintReverseArray(arr);
            }
        }

        private static void PrintReverseArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ",arr.Reverse()));
        }
    }
}
