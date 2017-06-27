using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            //    ArrayList Ar1 = new ArrayList();

            //    Ar1.Add(1);
            //    Ar1.Add(2);
            //    Ar1.Add(25.6);
            //    Ar1.Add(8);
            //    Ar1.Add(21);
            //    Ar1.Add(25);

            //    for (int i = 0; i < Ar1.Count; i++)
            //    {
            //        Console.WriteLine(Ar1[i]);
        
            // List<List<int>> PlayerList = new List<List<int>>();

            List<int> Ar2 = new List<int>();

            Ar2.Add(3);
            Ar2.Add(-1);

            Ar2.Add(5);

            Ar2.Add(10);

            Ar2.Sort();

            foreach (var item in Ar2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
