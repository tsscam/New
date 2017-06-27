using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise16
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                
                FourLoopOutPutTriangle(10);
               

            }
        }

        public static void FourLoopOutPutTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String('#', i) + new String(' ', n - i));
            }

            Console.WriteLine();
        }
    }
}
  