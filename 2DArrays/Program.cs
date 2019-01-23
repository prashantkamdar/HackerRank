using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = -99;
            int sum = 0;

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    sum = arr[x][y] + arr[x][y + 1] + arr[x][y + 2] +
                                               arr[x + 1][y + 1] +
                                   arr[x + 2][y] + arr[x + 2][y + 1] + arr[x + 2][y + 2];

                    if (maxValue < sum)
                        maxValue = sum;
                }
            }

            Console.WriteLine(maxValue);
        }
    }
}
