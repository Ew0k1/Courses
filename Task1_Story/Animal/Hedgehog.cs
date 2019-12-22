using System;



namespace Task1_Story
{
    class Hedgehog: Animal
    {
        private string kind = "ёж";
        private string gender = "мужской";
        private int maxSize = 5;
        private int size;
        public Hedgehog(string name, int size) : base(name, size) { }
        public Hedgehog() { }

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
            Console.WriteLine($"Я, {Name} {kind} — на репей похож.");
        }
    }
}
