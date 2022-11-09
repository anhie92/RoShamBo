using System;
namespace Roshambo
{
     class HumanPlayer:Player
    {
        public override Roshambo GenerateRoshambo()
        {


            // Prompt the user for for an entry
            Console.WriteLine("Please enter R P S ");
            string input = Console.ReadLine();
            
            if (input == "r"|| input =="rock")
            {
                Value = Roshambo.Rock;
                return Value;
            }
            else if (input == "p"|| input == "paper")
            {
                Value = Roshambo.Paper;
                return Value;
            }
            else if (input == "s" || input == "scissors")
            {
                Value = Roshambo.Scissors;
                return Value;
            }
            else
            {
                Value = Roshambo.InValid;
                return Value;
            }
            
        }
    }
}

