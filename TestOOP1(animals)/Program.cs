using System;

namespace TestOOP1_animals_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------------------------------------");

            Chickens myChicken = new Chickens();
            myChicken.SetLegs(2);
            myChicken.notify();
            myChicken.SoundOfChickens();

            Console.WriteLine("--------------------------------------------------");

            Dogs myDogs = new Dogs();
            myDogs.SetLegs(4);
            myDogs.notify2();
            myDogs.SoundOfDogs();

            Console.ReadKey();

        }
    }
}
