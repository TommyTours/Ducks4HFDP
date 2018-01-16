using System;

namespace Ducks
{
    public class DecoyDuck : Duck
    {
        public override string Display()
        {
            Console.WriteLine("Looks like a wooden Mallard");
            return "Looks like a wooden Mallard";
        }
    }
}