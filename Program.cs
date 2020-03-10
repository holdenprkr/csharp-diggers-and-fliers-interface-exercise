using System;

namespace DiggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            // SkyAnimals
            Finch finchy = new Finch();
            Parakeet perry = new Parakeet();
            // LandAnimals
            Mice mousey = new Mice();
            Gerbil gerbilly = new Gerbil();
            // WaterAnimals
            BettaFish betty = new BettaFish();
            Terrapin terry = new Terrapin();
            // UnderGroundAnimals
            Ant auntJemima = new Ant();
            CopperheadSnake copperFace = new CopperheadSnake();
            Earthworm wormy = new Earthworm();
            TimberRattlesnake shiver = new TimberRattlesnake();

            Flying SkyAnimals = new Flying();
            OnGround LandAnimals = new OnGround();
            Swimming WaterAnimals = new Swimming();
            UnderGround UnderGroundAnimals = new UnderGround();

            SkyAnimals.FlyingAnimals.Add(finchy);
            SkyAnimals.FlyingAnimals.Add(perry);

            LandAnimals.OnGroundAnimals.Add(mousey);
            LandAnimals.OnGroundAnimals.Add(gerbilly);

            WaterAnimals.SwimmingAnimals.Add(betty);
            WaterAnimals.SwimmingAnimals.Add(terry);

            UnderGroundAnimals.UnderGroundAnimals.Add(auntJemima);
            UnderGroundAnimals.UnderGroundAnimals.Add(copperFace);
            UnderGroundAnimals.UnderGroundAnimals.Add(wormy);
            UnderGroundAnimals.UnderGroundAnimals.Add(shiver);
        }
    }
}