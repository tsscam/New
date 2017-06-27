using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StreamReader reader = new StreamReader(TextFile(title));
            List<Availibility> status = new List<Availibility>();
            while (!Availible.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                Availibility status = new status();

          


            }

        }
    }
}
