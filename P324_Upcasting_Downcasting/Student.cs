using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Upcasting_Downcasting
{
    class Student:Human
    {
        public byte Point;

        public override void Info()
        {
            Console.WriteLine("Student");
        }
    }
}
