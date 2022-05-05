using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Upcasting_Downcasting
{
    class LionFish:Fish
    {
        public string Poison;

        public override void Eat()
        {
            Console.WriteLine("Small fishes");
        }

        public override void Swim()
        {
            Console.WriteLine("Lionfish swimming");
        }
    }
}
