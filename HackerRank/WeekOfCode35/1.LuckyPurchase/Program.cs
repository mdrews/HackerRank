using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace _1.LuckyPurchase
{
    class Program
    {
        static void Main(string[] args)
        {
            var bestPurchase = "";
            long bestPrice = long.MaxValue;
            List<string> Tests = new List<string>();
            Tests.Add("aasdfas 121");


            foreach (var test in Tests)
            {
                string[] tokens_s = test.Split(' ');
                string model = tokens_s[0];
                long price = Convert.ToInt64(tokens_s[1]);
                int count4 = price.ToString().Count(x => x == '4');
                int count7 = price.ToString().Count(x => x == '7');

                if ((price != 0) &&
                    (model != "") && (model != " ") && (price.ToString().IndexOfAny("01235689".ToCharArray()) == -1) && (count4 == count7))
                {
                    if (price < bestPrice)
                    {
                        bestPurchase = model;
                        bestPrice = price;
                    }
                }

            }
            if (bestPrice == int.MaxValue)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(bestPurchase);
            }

        }
    }
}
