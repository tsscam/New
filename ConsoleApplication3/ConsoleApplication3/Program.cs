using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Call Methods
            stars(5);


        }


        //method
        public static void stars(int n)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(new String('*', i));
                Console.WriteLine(new String('*', i));
                Console.WriteLine(new String('*', i));
                Console.WriteLine(new String('*', i));
                Console.WriteLine(new String('*', i));
            }

            Console.WriteLine();
        }
    }
}



//        //Problem 1B
//        public static void StairCase2(int n)
//        {
//            for (int i = n; i >= 1; i--)
//            {
//                Console.WriteLine(new String('#', i) + new String(' ', n - i));
//            }
//            Console.WriteLine();
//        }



//        //Problem 1C
//        public static void StairCase3(int n)
//        {
//            for (int i = n; i >= 1; i--)
//            {
//                Console.WriteLine(new String(' ', n - i) + new String('#', i));
//            }

//            Console.WriteLine();
//        }



//        // Problem 1D
//        public static void StairCase(int n)
//        {
//            for (int i = 1; i <= n; i++)
//            {
//                Console.WriteLine(new String(' ', n - i) + new String('#', i));
//            }

//            Console.WriteLine();
//        }
//    }
////}