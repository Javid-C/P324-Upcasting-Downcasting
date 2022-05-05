using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Upcasting_Downcasting
{
    class Samoyed:Dog,IShaveable
    {
        public string Fur;

        public override void Bark()
        {
            Console.WriteLine("Samoyed barking");
        }

        public override void Eat()
        {
            Console.WriteLine("Pedigree(Cat)");
        }

        public void Shave()
        {
            Console.WriteLine("More");
        }
    }
}
