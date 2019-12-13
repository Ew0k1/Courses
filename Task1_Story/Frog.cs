using System;

namespace Task1_Story
{
    class Frog: Animal
    {
        public Frog(string name, int size) : base(name, size) {}

        public override void GiveButtleRoar()
        {
            Console.WriteLine($"Я, {name}-квакушка.");
        }
    }
}
