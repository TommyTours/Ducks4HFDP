using System;

namespace Ducks
{
    public class Mallard : Duck
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

        public string Display()
        {
            Console.WriteLine("Green Head, Brown Body");
            return "Green Head, Brown Body";
        }
    }
}
