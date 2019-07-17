using System;

namespace DiggersAndFliers
{
    public class TimberRattlesnake : Animal, IUndulating
    {
        public string Name { get; set; }

        public string Wriggle()
        {
            return $"{Name}, the Timber Rattlesnake, is throwing a fit.";
        }
        public string Slither()
        {
            return $"{Name}, the Timber Rattlesnake, is on the move.";
        }
    }
}