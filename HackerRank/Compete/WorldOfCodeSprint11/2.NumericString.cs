using System;
using System.Linq;

namespace _2.NumericString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "12212";
            int k = 3;
            int b = 3;
            int m = 5;

            int sum = 0;

            for (int x = 0; x <= s.Length - k; x++)
            {
                string substring = s.Substring(x, k);
                double conversion = 0;
                for(int i = 0; i < k; i++)
                {
                    int c = 0;
                    c = substring[i] - '0';
                    //m = (substring[i] - '0');
                    //Console.WriteLine("M is: {0}", m);
                    conversion += c*Math.Pow(b, (b - i-1));
                    //Console.WriteLine("Calculation: {0}", conversion);
                    //Console.WriteLine(conversion);
                }
                sum += (int)conversion % m;
                //Console.WriteLine();
            }
            Console.WriteLine(sum);
        }
    }
}