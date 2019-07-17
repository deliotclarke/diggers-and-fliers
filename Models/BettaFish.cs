using System;

namespace DiggersAndFliers
{
    public class BettaFish : Animal, ISwimming
    {
        public string Name { get; set; }

        public string Swim()
        {
            return $"{Name}, the Betta Fish, is doing his thaaaang! He's swimming. Fish swim. It's almost all fish do.";
        }
        public string Dive()
        {
            return $"{Name}, the Betta Fish, is diving, it's a deep dive, because again - he's a fish. And diving is basically just swimming down. Which, of course, is what fish do.";
        }
    }
}