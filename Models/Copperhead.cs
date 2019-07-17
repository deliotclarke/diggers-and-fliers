using System;

namespace DiggersAndFliers
{
    public class Copperhead : Animal, IUndulating, ISwimming
    {
        public string Name { get; set; }

        public string Wriggle()
        {
            return $"{Name}, the Copperhead, is throwing a fit.";
        }
        public string Slither()
        {
            return $"{Name}, the Copperhead, is on the move.";
        }
        public string Swim()
        {
            return $"{Name}, the Copperhead, is swimming and that's terrifying.";
        }
        public string Dive()
        {
            return $"{Name}, the Copperhead, is diving to try to eat some fishes";
        }
    }
}