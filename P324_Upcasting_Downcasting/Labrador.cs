using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Upcasting_Downcasting
{
    class Labrador : Dog,IShaveable
    {
        public override void Bark()
        {
            Console.WriteLine("Labrador barking");
        }

        public override void Eat()
        {
            Console.WriteLine("Labrador eating fish and sometimes cat");
        }

        public void Shave()
        {
            Console.WriteLine("A little bit");
        }
    }
}
