using System;
using System.ComponentModel;


namespace Roshambo
{
    public static class Validator
    {
        public static bool GetYN()
        {
            Console.WriteLine("would you like to play again Y/N");
            string playInput = Console.ReadLine().ToLower();

            if (playInput == "y" || playInput == "yes")
            {
                return  true;
            }
            else
            {
                return false;
            }
        }


        //TryCatch attemt for Rock paper scissors input
        //public static string GetRockPaperScissors(string input)
        //{
        //    Console.WriteLine("Please enter R P S ");
            
        //    bool isValid = true;
        //    while(isValid)
        //    try
        //    { 
        //        if (input == "r" || input == "rock")
        //        {
        //            return input;
        //        }
        //        else if (input == "p" || input == "paper")
        //        {
        //            return input;
        //        }
        //        else if (input == "s" || input == "scissors")
        //        {
        //            return input;
        //        }
        //    }
        //   catch (ArgumentException)
        //    {
        //        input = "Invalid Choice entered please try again";
        //            isValid = false;
                
        //    }
        //    return input;
        //}
        

    }
}

