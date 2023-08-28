using System;
using System.Collections.Generic;


namespace Project1
{
    abstract class Bird
    {
        public abstract void Eat();
        public abstract void Move();
    }

    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("What do the eagles eat?");
            Console.WriteLine("Eagle diet is principally " +
                "mammals and birds, taken both alive and as carrion.");
            Console.WriteLine();
        }

        public override void Move()
        {
            Console.WriteLine("How are the eagles moving?");
            Console.WriteLine("These large birds move through the " +
                "landscape primarily by soaring—a style of flying " +
                "where they hold their wings outward and rarely flap, " +
                "saving them considerable energy.");
            Console.WriteLine();
        }
    }

    class Duck : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("What do the ducks eat?");
            Console.WriteLine("The natural diet of ducks and other " +
                "waterfowl is aquatic vegetation such as pond weed, " +
                "along with seeds, insects, worms, small water snails " +
                "and amphibians, and even crustaceans such as crayfish.");
            Console.WriteLine();
        }

        public override void Move()
        {
            Console.WriteLine("How are the ducks moving?");
            Console.WriteLine("Ducks use their feet to swim. " +
                "Their webbed feet are uniquely designed to help " +
                "them move through the water.");
            Console.WriteLine();
        }
    }

    class Class1
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();
            Duck duck = new Duck();
            Stack<Bird> birds = new Stack<Bird>();
            birds.Push(duck);
            birds.Push(eagle);
            

            foreach (Bird b in birds)
            {
                b.Eat();
                b.Move();
            }

        }

    }

}
