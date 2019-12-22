using System;

namespace Task1_Story
{
    class Mouse : Animal
    {
        private string kind = "мышка";
        private string gender = "женский";
        private int size;
        private int maxSize = 3;
        public Mouse(string name, int size) : base(name, size) {}
        public Mouse() { }

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
            Console.WriteLine($"Я, {kind}-норушка {Name}.");
        }
    }
}
