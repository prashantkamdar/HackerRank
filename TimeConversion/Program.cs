using System;

namespace TimeConversion
{
    class Solution
    {

        static void Main(String[] args)
        {
            string time = Console.ReadLine();

            var x = Convert.ToDateTime(time);

            Console.WriteLine(x.TimeOfDay);

            Console.ReadLine();
        }
    }
}