using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Upcasting_Downcasting
{
    class Husky : Dog, IShaveable
    {
        public override void Bark()
        {
            Console.WriteLine("Husky barking");
        }

        public override void Eat()
        {
            Console.WriteLine("Husky eating special cats");
        }

        public void Shave()
        {
            Console.WriteLine("4e4enka");
        }
    }
}
