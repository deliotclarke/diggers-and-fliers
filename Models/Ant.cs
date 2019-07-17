using System;

namespace DiggersAndFliers
{
    public class Ant : Animal, IDigging, IWalking
    {
        public string Name { get; set; }

        public string Dig()
        {
            return $"{Name}, the ant, is digging.";
        }
        public string CreateBurrow()
        {
            return $"{Name}, the ant, is helping to build a home.";
        }
        public string Walk()
        {
            return $"{Name}, the ant, is searching for food.";
        }
        public string Run()
        {
            return $"{Name}, the ant, is outta here!";
        }
    }
}