using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialChallengeSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int searchVal = Convert.ToInt32(Console.ReadLine());

            int arrLength = Convert.ToInt32(Console.ReadLine());

            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);


            for (int x = 0; x < arrLength; x++)
            {
                if (arr[x] == searchVal)
                {
                    Console.WriteLine(x);
                    break;
                }
            }
        }
    }
}
