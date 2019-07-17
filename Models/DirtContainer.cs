using System;
using System.Collections.Generic;

namespace DiggersAndFliers
{
    public class DirtContainer
    {
        public List<IDigging> HugeBucketOfDirt { get; set; }
        public DirtContainer()
        {
            HugeBucketOfDirt = new List<IDigging>();
        }
    }
}