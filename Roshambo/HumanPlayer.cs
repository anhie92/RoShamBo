using System;
namespace Roshambo
{
     class HumanPlayer:Player
    {
        public override Roshambo GenerateRoshambo()
        {
        
       
            // Prompt the user for for an entry
            Console.WriteLine("Please enter R P S ");
            string input = Console.ReadLine().ToLower();
            if (input == "r"|| input =="rock")
            {
                Value = Roshambo.Rock;
                return Roshambo.Rock;
            }
            else if (input == "p"|| input == "paper")
            {
                Value = Roshambo.Paper;
                return Roshambo.Paper;
            }
            else
            {
                Value = Roshambo.Scissors;
                return Roshambo.Scissors;
            }
        }
    }
}

