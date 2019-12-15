using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Story
{
    class Dinosaur : Animal
    {
        public Dinosaur(string name, int size) : base(name, size) { }
        public override void GiveButtleRoar()
        {
            Console.WriteLine("Аррррррррр, Я - Динозавр!!!");
        }
    }
}
