using System;
using System.Collections.Generic;

namespace DiggersAndFliers
{
    public class SingleWaterContainer
    {
        List<ISwimming> FishBowl { get; set; }
        SingleWaterContainer()
        {
            FishBowl = new List<ISwimming>();
        }
    }
}