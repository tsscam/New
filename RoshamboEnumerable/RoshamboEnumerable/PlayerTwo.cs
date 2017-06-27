using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboEnumerable
{
    class PlayerTwo
    {
        public override RoshamboValue GetRosshamoValue()
        {
            Console.WriteLine("Enter 1 for R, 2 for P, 3 for S");

            int choice = int.Parse(Console.ReadLine());
            GetRosshamoValue UserChoice = GetRosshamoValue.Rock;

            switch (choice)
            {
                case 1:
                    UserChoice = RoshamboValue.Rock;
                    break;
                case 2: 
                    UserChoice = RoshamboValue.Paper;
                    break;
                case 3:
                    UserChoice = RoshamboValue.Scissors;
                    break;


            }
        }
    }
}
