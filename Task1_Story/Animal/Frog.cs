using System;

namespace Task1_Story
{
    class Frog: Animal
    {
        private string kind = "лягушка";
        private string gender = "женский";
        private int maxSize = 3;
        private int size;
        public Frog(string name, int size) : base(name, size) {}
        public Frog() { }

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
            Console.WriteLine($"Я, {kind}-квакушка {Name}.");
        }
    }
}
