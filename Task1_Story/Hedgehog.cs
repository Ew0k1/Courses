using System;



namespace Task1_Story
{
    class Hedgehog: Animal
    {
        public Hedgehog(string name, int size) : base(name, size) { }

        public override void GiveButtleRoar()
        {
            Console.WriteLine($"Я, {name} — на репей похож.");
        }
    }
}
