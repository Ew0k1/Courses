using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Story
{
    class Dinosaur : Animal
    {
        private string kind = "динозавр";

        private string gender = "мужской";

        private int maxSize = 100;
        private int size;
        public Dinosaur(string name, int size) : base(name, size) { }
        public Dinosaur() { }

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
            Console.WriteLine("Аррррррррр, Я - Динозавр!!!");
        }
    }
}
