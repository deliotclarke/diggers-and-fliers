using System;

namespace DiggersAndFliers
{
    public class Gerbil : Animal, IWalking, IDigging
    {
        public string Name { get; set; }

        public string Walk()
        {
            return $"{Name}, the gerbil, is on the move!";
        }
        public string Run()
        {
            return $"{Name}, the gerbil, is really on the move!!";
        }
        public string Dig()
        {
            return $"{Name}, the gerbil, is digging.";
        }
        public string CreateBurrow()
        {
            return "${Name}, the gerbil, is building an adorable underground home.";
        }
    }
}