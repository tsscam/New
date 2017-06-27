using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionNumTwo
{
    class Program
    {
        static void Main(string[] args)
        //vertical one challenging for console//
        //user is entering numbers is entered with -1...
        //let me get zero to 100
        //range validation
        //when voting you can do a quick count.How
        {
            //Variables
            int input;
            int[] HistogramArray = new int[10];
            while (true)
            {
                // input
                Console.WriteLine("Please Enter a value between zero and 100");
                


                if (input == -1)
                    break;

                //processing

                Console.WriteLine(input / 10);
                int index = input / 10;

                //if (index == 0)
                //    HistogramArray[1]++;
                //else if (input == 1)
            //    //    HistogramArray[1]++;
            //    if (index == 10)
            //        index = index = 9;
            //        HistogramArray[index]++;
            //    //output
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Console.WriteLine(HistogramArray[i]);
            //    }
            //    }
            //}
        
//        public static int GetValidInteger()
//    {
//            int input;
//        input = GetValidInteger(-1, 100);
//        while (!int.TryParse(Console.ReadLine(), out input))
//            {
//                Console.WriteLine("Please enter a valid input.");
//            }
//            return input;
//        }
//        //Validates that integer is within a given range
//        public static int GetNumberInRange(int min, int max)
//        {
//            int input = GetValidInteger();
//            while (input < min || input > max)
//            {
//                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
//                input = GetValidInteger();
//            }
//            return input;
//        }
//    }
//}