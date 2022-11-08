using System;
namespace Roshambo
{
    class RandomPlayer:Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 3);
            Value = (Roshambo)num;
            return Value;
        }
        

        
    }
}

