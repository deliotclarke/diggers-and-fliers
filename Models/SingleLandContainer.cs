using System;
using System.Collections.Generic;

namespace DiggersAndFliers
{
    public class SingleLandContainer
    {
        public List<IUndulating> PlasticBox { get; set; }
        public SingleLandContainer()
        {
            PlasticBox = new List<IUndulating>();
        }
    }
}