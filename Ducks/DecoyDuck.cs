using System;

namespace Ducks
{
    public class DecoyDuck : Duck
    {
        public string Quack()
        {
            Console.WriteLine("Silence");
            return "Silence";
        }

        public string Swim()
        {
            Console.WriteLine("Splash Splash");
            return "Splash Splash";
        }

        public string Fly()
        {
            Console.WriteLine("I can't fly; I'm Wood");
            return "I can't fly; I'm Wood";
        }

        public string Display()
        {
            Console.WriteLine("Looks like a wooden Mallard");
            return "Looks like a wooden Mallard";
        }
    }
}