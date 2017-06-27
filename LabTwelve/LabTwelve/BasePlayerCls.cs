using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelve
{
    class BasePlayerCls
    {
        public enum Hand { rock = 1, paper, scissors };
        public enum Outcome { Win, Lose, Tie };
        public Hand ComputerHand { get; set; }
        public char UserSelection { get; set; }
    }
    public Hand getUserHand()
    {
        while (!validateSelection)
        {
            Console.Clear();
            Console.WriteLine("Invalid INput");
            UserSelection = Convert.ToChar(Console.ReadLine());
        }
    }
    public bool validateSelection()
    {
        char value = Char.ToUpper(UserSelection);
        if (value != 'R' && value != 'P' && value != 'S')
            return false;
        return true;
    }
    private void Screen()
    {
        Console.WriteLine("Rock");
        Console.WriteLine("Paper");
        Console.WriteLine("Scissors");
    }
}
public Outcome DetermineWinner()
{
    string Hand;
    string ComputerHand;

    if (PlayerTwo == Hand.Scissors && BasePlayerCls == Hand.Paper)
        return Outcome.Win;
    else if (PlayerHand == Hand.Rock && BasePlayerCls == Hand.Scissors)
        return Outcome.Win;
    else if (PlayerHand == Hand.Paper && BasePlayerCls == Hand.Rock)
        return Outcome.Win;
    else if (PlayerHand == Hand.Scissors && BasePlayerCls == Hand.Rock)
        return Outcome.Lose;
    else if (PlayerHand == Hand.Rock && BasePlayerCls == Hand.Paper)
        return Outcome.Lose;
    else if (PlayerHand == Hand.Paper && BasePlayerCls == Hand.Scissors)
        return.Outcome.Lose;
}
   
