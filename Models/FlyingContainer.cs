using System;
using System.Collections.Generic;

namespace DiggersAndFliers
{
    public class FlyingContainer
    {
        List<IFlying> GiantBirdcage { get; set; }
        public FlyingContainer()
        {
            GiantBirdcage = new List<IFlying>();
        }
    }
}