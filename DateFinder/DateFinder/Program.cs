using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFinder
{
    class Program
         {
            public void BookAvailability()
            {
                    

                var random = new Random(Guid.NewGuid().GetHashCode());
                var book = new List<string> {"Available", "Checked Out"};
                int index = random.Next(book.Count);
                string RandomString = book[index];

                
            }
        }
    }