using System;

namespace P324_Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human();
            //Student student = new Student();
            //human.Info();
            //student.Info();

            //human = student;
            //Console.WriteLine("After casting");
            //human.Info();
            //student.Info();

            //Samoyed samoyed = new Samoyed();

            //Dog dog = new Samoyed();

            //Console.WriteLine(dog.GetType());

            //Animal animal = new Samoyed();

            //Animal fish = new LionFish();


            //Downcasting

            Animal samoyed = new Samoyed();

            Animal animal = new LionFish();

            //LionFish lionFish = animal as LionFish;
            //if(lionFish != null)
            //{
            //    lionFish.Poison = "Deadly";
            //    Console.WriteLine(lionFish.Poison);
            //}

            //if(samoyed is LionFish)
            //{
            //    LionFish lionFish = (LionFish)samoyed;
            //    lionFish.Poison = "Deadly";
            //    Console.WriteLine(lionFish.Poison);
            //}
            //else
            //{
            //    Console.WriteLine("Lionfish deyil");
            //}

            //treatDoberman(new Doberman());
            //treatSamoyed(new Samoyed());
            //treatLabrador(new Labrador());

            //Console.WriteLine("After casting");

            //Treat(new Samoyed());
            //Treat(new Labrador());
            //Treat(new Doberman());
            //Treat(new Husky());
            //Manat manat = new Manat { Azn = 200 };
            //Dollar dollar = (Dollar)manat;
            //Console.WriteLine(dollar.Usd);

            Person p1 = new Person();
            p1.Age = 30;

            Person p2 = new Person();
            p2.Age = 30;
            Console.WriteLine(p1 == p2);
        }

        public static void treatSamoyed(Samoyed samoyed)
        {
            samoyed.Bark();
        }
        public static void treatDoberman(Doberman doberman)
        {
            doberman.Bark();

        }
        public static void treatLabrador(Labrador labrador)
        {
            labrador.Bark();

        }
        public static void Treat(Dog dog)
        {
            dog.Bark();
            dog.Eat();
            Console.WriteLine("\n");

            if (dog is IShaveable)
            {

                IShaveable shave = (IShaveable)dog;
                shave.Shave();

            }
            Console.WriteLine("\n");


        }
    }

    class Manat
    {
        public double Azn;

        public static explicit operator Dollar(Manat manat)
        {
            return new Dollar { Usd = manat.Azn / 2 };
        }

    }
    class Dollar
    {
        public double Usd;
    }

    class Person
    {
        public byte Age;

        public static bool operator >(Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }
        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }

        //public static bool operator ==(Person p1, Person p2)
        //{
        //    return p1.Age == p2.Age;
        //}
        //public static bool operator !=(Person p1, Person p2)
        //{
        //    return p1.Age != p2.Age;
        //}

    }
}
