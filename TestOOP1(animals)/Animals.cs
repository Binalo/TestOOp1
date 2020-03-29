using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOP1_animals_
{
    class Animals
    {
        protected int legs;
        public void SoundOfDogs()
        {
            Console.WriteLine("Gaau Gaauuu. ... . . . Gaauuu");
        }
        public void SoundOfChickens()
        {
            Console.WriteLine("Ò. .o . o ... Ó ..o..o");
        }
        public void SetLegs(int n)
        {
            legs = n;
        }
    }
}
