using System;

namespace Ducks
{
    public class Duck
    {
        public string Quack()
        {
            Console.WriteLine("Quack Quack");
            return "Quack Quack";
        }

        public string Swim()
        {
            Console.WriteLine("Splash Splash");
            return "Splash Splash";
        }

        public string Fly()
        {
            Console.WriteLine("Flap Flap");
            return "Flap Flap";
        }

        public virtual string Display()
        {
            Console.WriteLine("Vaguely Duck Shaped");
            return "Vaguely Duck Shaped";
        }

    }
}
