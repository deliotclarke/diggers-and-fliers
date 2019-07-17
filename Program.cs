using System;
using System.Collections.Generic;
using System.Linq;

namespace DiggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> allAnimals = new List<Animal>()
            {
                new Ant() { Name = "Angela", keptAlone = false },
                new BettaFish() { Name = "Betty", keptAlone = true },
                new BettaFish() { Name = "Bernie", keptAlone = false},
                new Copperhead() { Name = "Cooper", keptAlone = true },
                new Earthworm() { Name = "Jim",  keptAlone = false },
                new Finch() { Name = "Finn", keptAlone = false },
                new Gerbil() { Name = "Gary", keptAlone = false },
                new Mice() { Name = "Manny", keptAlone = false },
                new Parakeet() { Name = "Pamela", keptAlone = false },
                new Terrapin() { Name = "Teddy", keptAlone = false },
                new TimberRattlesnake() { Name = "Randy", keptAlone = true }
            };

            FriendlyLandContainer TheBigOne = new FriendlyLandContainer();
            FriendlyWaterContainer GiantAquarium = new FriendlyWaterContainer();
            DirtContainer TheHugeBucket = new DirtContainer();
            FlyingContainer OneBigBirdcage = new FlyingContainer();
            Shelf Shelf = new Shelf();
            var TheShelf = Shelf.TheShelf;

            // TheBigOne.DirtAquarium = from animal in allAnimals
            //                          where animal.keptAlone = false

            //                          select animal

            TheBigOne.DirtAquarium = allAnimals.Where(ani => ani.keptAlone == false).OfType<IWalking>().ToList();
            GiantAquarium.WaterAquarium = allAnimals.Where(ani => ani.keptAlone == false).OfType<ISwimming>().ToList();
            TheHugeBucket.HugeBucketOfDirt = allAnimals.Where(ani => ani.keptAlone == false).OfType<IDigging>().ToList();


            allAnimals.Where(ani => ani.keptAlone)
                .OfType<IUndulating>()
                .ToList()
                .ForEach(aniList =>
                    {
                        SingleLandContainer oneContainer = new SingleLandContainer();
                        oneContainer.PlasticBox.Add(aniList);
                        TheShelf.Add(oneContainer.PlasticBox);
                    });

        }
    }
}



