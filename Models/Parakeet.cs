using System;

namespace DiggersAndFliers
{
    public class Parakeet : Animal, IFlying
    {
        public string Name { get; set; }

        public string Fly()
        {
            return $"{Name}, the parakeet, is flying.";
        }
        public string Land()
        {
            return $"{Name}, the parakeet, is flying.";
        }
    }
}