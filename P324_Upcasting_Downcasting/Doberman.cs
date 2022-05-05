using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Upcasting_Downcasting
{
    class Doberman : Dog
    {
        public override void Bark()
        {
            Console.WriteLine("Doberman barking");
        }

        public override void Eat()
        {
            Console.WriteLine("Doberman eat cat");
        }
    }
}
