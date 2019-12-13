using System;

namespace Task1_Story
{
    class Bunny:Animal
    {
        public Bunny(string name, int size) : base(name, size) { }

        public override void GiveButtleRoar()
        {
            Console.WriteLine($"Я, {name}-побегайчик.");
        }
    }
}
