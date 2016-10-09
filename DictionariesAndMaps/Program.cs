using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofLines = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            string inputLine = "";
            string name = "";
            string number = "";


            for (int i = 0; i < numberofLines; i++)
            {
                inputLine = Console.ReadLine();
                name = inputLine.Split(' ')[0];
                number = inputLine.Split(' ')[1];

                phoneBook.Add(name,number);
            }

            while(true)
            {
                string lookup = Console.ReadLine();

                if (phoneBook.ContainsKey(lookup))
                {
                    Console.WriteLine($"{lookup}={phoneBook[lookup]}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
