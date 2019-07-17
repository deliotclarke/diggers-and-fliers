using System;

namespace DiggersAndFliers
{
    public class Finch : Animal, IFlying
    {
        public string Name { get; set; }

        public string Fly()
        {
            return $"{Name}, the finch, is flying.";
        }
        public string Land()
        {
            return $"{Name}, the finch, is flying.";
        }
    }
}