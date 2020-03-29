using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOP1_animals_
{
    class Dogs : Animals
    {
        public void notify2()
        {
            Console.WriteLine("The number of feet of the Dog is {0}", legs);
        }
    }
}
