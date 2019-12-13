using System;

namespace Task1_Story
{
    class Bear:Animal
    {
        public Bear(string name, int size) : base(name, size) { }

        public override void GiveButtleRoar()
        {
            Console.WriteLine($"Я, косолапый {name}.");
        }
    }
}
