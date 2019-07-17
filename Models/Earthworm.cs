using System;

namespace DiggersAndFliers
{
    public class Earthworm : Animal, IDigging, IUndulating
    {
        public string Name { get; set; }

        public string Dig()
        {
            return $"{Name}, the earthworm, is digging.";
        }
        public string CreateBurrow()
        {
            return $"{Name}, the earthworm, is building a home.";
        }
        public string Wriggle()
        {
            return $"{Name} thinks it's raining, he gon' wriggle when it rains.";
        }
        public string Slither()
        {
            return $"{Name}, the earthworm, is doing his best snake impression.";
        }
    }
}