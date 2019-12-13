using System;

namespace Task1_Story
{
    class Mouse : Animal
    {
        public Mouse(string name, int size) : base(name, size) {}
        public override void GiveButtleRoar()
        {
            Console.WriteLine($"Я, {name}-норушка.");
        }
    }
}
