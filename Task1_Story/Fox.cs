using System;

namespace Task1_Story
{
    class Fox: Animal
    {
        public Fox(string name, int size) : base(name, size) { }

        public override void GiveButtleRoar()
        {
            Console.WriteLine($"Я, {name}-сестричка.");
        }
    }
}
