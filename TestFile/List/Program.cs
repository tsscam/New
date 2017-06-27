using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            

            List <string> myList = new List<string>();
            myList.Add("James");
            myList.Add("Sarah");
            myList.Add("Suzzie");
            myList.Add("Colleen");

            List<string> SearchResult= myList.Where(x=>x.StartsWith("J")
            || x.EndsWith ("k")).ToList();

            foreach (string res in SearchResult)
            {
                Console.WriteLine(res);
            }
            myList.ConvertAll(x => x.ToUpper()).ToList();

        }
    }
}
