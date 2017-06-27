using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomObject = new Random();
            Console.WriteLine("{0}", randomObject.Next(10) + 1);

            while (true)
            {
                string String, ReverseStr = "";
                Console.Write("Please type 5");
                String = Console.ReadLine();

                switch (randomObject)
                {
                    case 0:
                        {
                            Console.WriteLine("Again");

                            break;
                        }

                        for (int i = String.Length - 1; i >= 0; i--)
                        {
                            ReverseStr = ReverseStr + String[i];
                        }
                        Console.WriteLine("Those 5 numbers reversed are : {0}", ReverseStr);
                        Console.ReadLine();
                }
            }
        }
    }
}