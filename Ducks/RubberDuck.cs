using System;

namespace Ducks
{
    public class RubberDuck : Duck
    {
        public string Quack()
        {
            Console.WriteLine("Squeak Squeak");
            return "Squeak Squeak";
        }

        public string Swim()
        {
            Console.WriteLine("Splash Splash");
            return "Splash Splash";
        }

        public string Fly()
        {
            Console.WriteLine("I can't fly; I'm Rubber");
            return "I can't fly; I'm Rubber";
        }

        public string Display()
        {
            Console.WriteLine("Yellow and Rubber");
            return "Yellow and Rubber";
        }
    }
}