using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleClassExample
{
    class Program
    {
        static void Main(string[] args)
        { // ask user to initialize triangle measurements
            //print the area of those triangles

            //array of triagles created by
            TriangleClass[] TArray = new TriangleClass[3];

            //creating the objects by using a for loop
            for (int i = 0; i < TArray.Length; i++)
            //slots for information is obtained by creating an object here
            {
                TArray[i] = new TriangleClass();

                Console.WriteLine("Please enter a value for Base: ");
                TArray[i].TriangleBase1 = ValidateConsoleInput.GetInRangeDouble(0, double.MaxValue);

                Console.WriteLine("Please enter a value for Height: ");
                TArray[i].TriangleHeight1 = ValidateConsoleInput.GetInRangeDouble(0, double.MaxValue);

                //temp is the pointer to get each triangle or object we are creating (elements)
                foreach (TriangleClass temp in TArray)
                {
                    Console.WriteLine(temp.GetArea());
                }


            }
        }
    }
}



        
        //{
        //    TriangleClass t = new TriangleClass();
        //    TriangleClass t2 = new TriangleClass(7, 7);
        //    Console.WriteLine(t2.GetArea());

        //    TriangleClass[] TriangleArray = new TriangleClass[5];

        //    TriangleArray[0] = t;
        //    TriangleArray[0] = t2;

        //    for (int i = 0; i < TriangleArray.Length; i++) 
        //    {
        //        Console.WriteLine(TriangleArray[i].GetArea());
        //    }


 