using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOP1_animals_
{
    class Chickens : Animals
    {
        public void notify()
        {
            Console.WriteLine("The number of feet of the chicken is {0} ", legs);
        }
    }
}
