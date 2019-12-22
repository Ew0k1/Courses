using System;

namespace Task1_Story
{
    class Bunny:Animal
    {
        private string kind = "зайчик";
        private string gender = "мужской";
        private int maxSize = 5;
        private int size;
        public Bunny(string name, int size) : base(name, size) { }
        public Bunny() { }

        public override string Kind
        {
            get
            {
                return kind;
            }
        }
        public override string Gender
        {
            get
            {
                return gender;
            }
        }
        public override int Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value > maxSize)
                {
                    size = maxSize;
                }
                else
                {
                    size = value;
                }
            }
        }

        public override int MaxSize
        {
            get
            {
                return maxSize;
            }
        }

        public override void GiveButtleRoar()
        {
            Console.WriteLine($"Я, {kind}-побегайчик {Name}.");
        }

    }
}
