using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRowColumn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How big is the array?");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] arraytoCheck = new int[size, size];
            //           Console.WriteLine(CheckDiagArray(size, arraytoCheck));

            for (int row = 0; row < size; row++)
            {
                Console.WriteLine("Enter values for row {0}:", row + 1);
                for (int column = 0; column < size; column++)
                {
                    inputDataToArray(row, column, arraytoCheck);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Is the array symmetrical?");
            Console.WriteLine(size);
        }

        private static void inputDataToArray(int row, int column, int[,] array) // this method gets the input from the user (array size)
        {
            array[row, column] = int.Parse(Console.ReadLine());}

             private static bool CheckDiagArray(int size, int[,] arraytoCheck)  // this method iterates through all the values in the array, using the "size" to set row/column size
        {
            return true;

            List<Person> personList = new List<Person>();

            personList.Add(stu1);
            personList.Add(sta1);
            personList.Add(new Staff("Seymour Skinner", "555 Somewhere Street, Springfield", "Springfield Elementary", 65000.00));

            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine(personList[i]);
            }
    }
}