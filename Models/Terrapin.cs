using System;

namespace DiggersAndFliers
{
    public class Terrapin : Animal, ISwimming, IWalking
    {
        public string Name { get; set; }

        public string Walk()
        {
            return $"{Name}, the Terrapin, is on the move!";
        }
        public string Run()
        {
            return $"{Name}, the Terrapin, is really on the move!! Jk, Turtles can't run. BUT HE'S DOING HIS BEST";
        }
        public string Swim()
        {
            return $"{Name}, the Terrapin, is doing his thaaaang! He's swimming. Fish swim. It's almost all fish do.";
        }
        public string Dive()
        {
            return $"{Name}, the Terrapin, is diving, it's a deep dive, because again - he's a fish. And diving is basically just swimming down. Which, of course, is what fish do.";
        }
    }
}