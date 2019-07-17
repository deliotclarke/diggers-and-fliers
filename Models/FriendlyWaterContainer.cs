using System;
using System.Collections.Generic;

namespace DiggersAndFliers
{
    public class FriendlyWaterContainer
    {
        public List<ISwimming> WaterAquarium { get; set; }
        public FriendlyWaterContainer()
        {
            WaterAquarium = new List<ISwimming>();
        }
    }
}