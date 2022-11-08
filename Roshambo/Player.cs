using System;
namespace Roshambo
{
    abstract class Player
    {
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public Roshambo Value { get; set; }

        public abstract Roshambo GenerateRoshambo();
        
    }
}

