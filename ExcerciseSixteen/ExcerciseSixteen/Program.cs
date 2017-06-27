using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseSixteen
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                //Call Methods
                //StairCase(8);
                StairCase1(8);
                //StairCase2(10);
                //StairCase3(8);

            }
        }


        //Problem 1A
        public static void StairCase1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String('#', i) + new String(' ', n - i));
            }

            Console.WriteLine();
        }
    }
}



        //Problem 1B
        //    public static void StairCase2(int n)
        //    {
        //        for (int i = n; i <= 1; i++)
        //        {
        //            Console.WriteLine(new String('#', i) + new String(' ', n - i));
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //}



//Problem 1C
//        public static void StairCase3(int n)
//        {
//            for (int i = n; i >= 1; i--)
//            {
//                Console.WriteLine(new String(' ', n - i) + new String('#', i));
//            }

//            Console.WriteLine();
//        }
//    }
//}



// Problem 1D
//        public static void StairCase(int n)
//        {
//            for (int i = 1; i <= n; i++)
//            {
//                Console.WriteLine(new String(' ', n - i) + new String('#', i));
//            }

//            Console.WriteLine();
//        }
//    }
//}