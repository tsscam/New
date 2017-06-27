using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArrayCarExample
{
    class Program
      {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the GC Motor admin console!\n");

                Console.WriteLine("How many cars are you entering: ");

                int sizeOfLot = int.Parse(Console.ReadLine());
                Car[] CarsArray = new Car[sizeOfLot];

                for (int i = 0; i < sizeOfLot; i++)
                {

                    Console.WriteLine($"Enter Make of Car No. {i + 1}: ");
                    string MakeofCar = Console.ReadLine();

                    Console.WriteLine($"Enter Model of Car No. {i + 1}: ");
                    string ModelofCar = Console.ReadLine();

                    Console.WriteLine($"Enter Year of Car No. {i + 1}: ");
                    int YearofCar = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Enter Price of Car No. {i + 1}: ");
                    double PriceofCar = double.Parse(Console.ReadLine());

                    CarsArray[i] = new Car(MakeofCar, ModelofCar, YearofCar, PriceofCar);



                }

                for (int i = 0; i < sizeOfLot; i++)
                {
                    Console.WriteLine(CarsArray[i].PropMakeOfCar);
                    Console.WriteLine(CarsArray[i].PropModelOfCar);
                    Console.WriteLine(CarsArray[i].PropYearOfCar);
                    Console.WriteLine(CarsArray[i].PropPriceOfCar);
                }

           }
        }
    }