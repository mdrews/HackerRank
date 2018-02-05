using System;
using System.Security.Cryptography.X509Certificates;

namespace _2d_array
{
    class Program
    {
        public static void HighestHourglass(int[][] array)
        {
            int highestHourglassSum = 0;
            int currentHourglassSum = 0;
            for (int x = 0; x < 4; x++)
            {
                for(int y = 0; y < 4; y++)
                {
                    currentHourglassSum = array[x][y] + array[x][y + 1] + array[x][y + 2]
                                          + array[x + 1][y + 1] + array[x + 2][y] + array[x + 2][y + 1] + array[x + 2][y + 2];
                    if (currentHourglassSum > highestHourglassSum)
                    {
                        highestHourglassSum = currentHourglassSum;
                    }
                    Console.WriteLine(currentHourglassSum);
                }
            }
            Console.WriteLine(highestHourglassSum);
        }

        static void Main(string[] args)
        {
            int[][] arr = new int[6][]
            {
                new int[] {1, 1, 1, 0, 0, 0},
                new int[] {0, 1, 0, 0, 0, 0},
                new int[] {1, 1, 1, 0, 0, 0},
                new int[] {0, 0, 2, 4, 4, 0},
                new int[] {0, 0, 0, 2, 0, 0},
                new int[] {0, 0, 1, 2, 4, 0}
            };
            
            HighestHourglass(arr);
            
        }
    }
}
