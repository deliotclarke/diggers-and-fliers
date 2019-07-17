using System;
using System.Collections.Generic;

namespace DiggersAndFliers
{
    public class Shelf
    {
        public List<List<IUndulating>> TheShelf { get; set; }

        public Shelf()
        {
            TheShelf = new List<List<IUndulating>>();
        }
    }
}