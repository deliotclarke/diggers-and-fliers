using System;
using System.Collections.Generic;

namespace DiggersAndFliers
{
    public class FriendlyLandContainer
    {
        public List<IWalking> DirtAquarium { get; set; }

        public FriendlyLandContainer()
        {
            DirtAquarium = new List<IWalking>();
        }
    }
}