using System;

namespace DiggersAndFliers
{
    public class Mice : Animal, IWalking, IDigging
    {
        public string Name { get; set; }

        public string Walk()
        {
            return $"{Name}, the mouse, is on the move!";
        }
        public string Run()
        {
            return $"{Name}, the mouse, is really on the move!!";
        }
        public string Dig()
        {
            return $"{Name}, the mouse, is digging.";
        }
        public string CreateBurrow()
        {
            return "${Name}, the mouse, is building an adorable underground home.";
        }
    }
}