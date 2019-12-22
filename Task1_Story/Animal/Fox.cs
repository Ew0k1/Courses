using System;

namespace Task1_Story
{
    class Fox : Animal
    {
        private string kind = "лисичка";
        private string gender = "женский";
        private int maxSize = 10;
        private int size;
        public Fox(string name, int size) : base(name, size) { }
        public Fox() { }

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
            Console.WriteLine($"Я, {kind}-сестричка {Name}.");
        }
    }
}
