using System;
namespace Roshambo
{
    class RockPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
        public RockPlayer(string name)
            {
            Name = name;
            }
       
    }
}

