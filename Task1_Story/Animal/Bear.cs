using System;

namespace Task1_Story
{
    class Bear:Animal
    {
        private string kind = "медведь";

        private string gender = "мужской";

        private int maxSize = 30;
        private int size;
        
        public Bear(string name, int size) : base(name, size) { }
        public Bear(){ }

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

        public override int MaxSize
        {
            get
            {
                return maxSize;
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
                if(value>maxSize)
                {
                    size= maxSize;
                }
                else
                {
                    size = value;
                }
            }
        }

        public override void GiveButtleRoar()
        {
            Console.WriteLine($"Я, косолапый {kind} {Name}.");
        }
    }
}
