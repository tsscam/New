using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Dictionary<string, int>();
            inventory.Add("Aitle1", 1);
            inventory.Add("Citle2", 1);
            inventory.Add("Bitle3", 1);

            var keys = inventory.Keys;
            Console.WriteLine("Number of these available are: " + keys.Count);

            foreach (var key in keys)
            {
                Console.WriteLine(key + ": " + inventory[key]);
            }
            string[] keysArray = keys.ToArray();
            Array.Sort(keysArray);//sorts the array

            foreach (var key in keysArray)//goes thru the array one at a time
            {   //sorted alphabetically
                Console.WriteLine(key + ": " + inventory[key]);
            }
            double value; //it will be a double if successfully returned back from method
            if (inventory.TryGetValue("Citle2", out value))
            //returns a true or false -- boolean true means succeeded for double
            { 
                Console.WriteLine("Books Inventory: " + value);
        }
        else
        {
        Console.WriteLine("Book No Longer Availble, but will be returned shortly");
        
            }
        }
    }
}
