using System;
using System.ComponentModel;
using Roshambo;

namespace Roshambo
{
    public class Validator
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
    }
}

