using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzPuzzProject
{
    class FizzBuzz
    {
        public static string GetFizzBuzz (int x)
        {    if (x % 3 == 0)
                //return x+"";
                return "Fizz";
            else if (x == 5)
                return "Buzz";
            else 
            return x.ToString();
        }
    }
}
