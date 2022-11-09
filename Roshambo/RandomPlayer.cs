using System;
using System.Reflection;

namespace Roshambo
{
    class RandomPlayer:Player
    {
       


        public RandomPlayer()
        { }

        public RandomPlayer(string name)
        {
            Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 3);
            Value = (Roshambo)num;
            return Value;
        }
    }
}

