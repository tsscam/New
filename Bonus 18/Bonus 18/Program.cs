using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a new object in main method using the Car class
            Car CarInput = new Car();
            //creating a 2d list to store car data

            List<List<string>> CarInventory = new List<List<string>>();

            //Message displayed to user
            Console.WriteLine("How many cars would you like to add to the Database : ");
            //Converts the user input into a string
            string data = Console.ReadLine();

            //Message displayed to user
            Console.WriteLine("Required fields are Make, Model, Year & Price : ");
        }

             public static void CarInfo(int input, Car CarInput, List<List<string>> carList)
        {
            //for loop used to enter data for each car
            for (int i = 1; i <= input; i++)
            {
                //sublist used when printing data in rows
                List<string> sublist = new List<string>();

            //    Console.Write("Make of Car {0}", i);
            //    CarInput.Make = Console.ReadLine();
            //    sublist.Add(CarInput.Make);

            //    Console.Write("Model of Car {0}: ", i);
            //    CarInput.Model = Console.ReadLine();
            //    sublist.Add(CarInput.Model);

            //    Console.Write("Year of Car {0}: ", i);
            //    InputMake = Double.Parse(InputMake);
            //    CarInput.Year = Console.ReadLine();

            //    Console.Write("Price of Car {0}: ", i);
            //    CarInput.Price = Console.ReadLine();

            //    // Declare Array & Initialize Range for Number of Cars
            //    int NumCars = Validation.GetRange(1, 5);
            //    Car[] CarList = new Car[NumCars];
            //    Validation.GetInput(NumCars, CarList);
            //    GetInventory(NumCars, CarList);

            //}



        // Method Get Inventory List
        public static void GetInventory(int NumCars, Car[] CarList)
        {

            Console.WriteLine("----------  Current Inventory  ----------\n");

            for (int i = 0; i < NumCars; i++)
            {

                // Print Output for User Input/Inventory
                Console.WriteLine($"{CarList[i].CarMake.Trim()}\t\t{CarList[i].CarModel.Trim()}\t\t{CarList[i].CarYear}\t\t{CarList[i].CarPrice.ToString("$#,#.00")}");
            }
        }


        carList.Add(sublist);
            }




        }




    }
  }
}
