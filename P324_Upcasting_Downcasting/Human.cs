using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Upcasting_Downcasting
{
    class Human
    {
        public string Name;

        public virtual void Info()
        {
            Console.WriteLine("Human");
        }
    }
}
