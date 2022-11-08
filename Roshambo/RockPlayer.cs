using System;
namespace Roshambo
{
     class RockPlayer:Player
    {
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
       
    }
}

