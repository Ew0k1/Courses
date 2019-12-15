using System;
using System.Collections.Generic;
using System.Threading;

namespace Task1_Story
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Mouse mouse = new Mouse("Мыша", 2);
            Frog frog = new Frog("Лягушка", 3);
            Hedgehog hedgehog = new Hedgehog("Ёж", 5);
            Bunny bunny = new Bunny("Зайчик", 7);
            Fox fox = new Fox("Лисичка", 10);
            Bear bear = new Bear("Медведь", 30);

            List<Animal> animals = new List<Animal> { mouse, frog, hedgehog, bunny, fox, bear };

            StoryController story = new StoryController(animals);

          
            story.TellTheBeginning();

            story.TellTheMainPart();
            
            Console.ReadLine();

            
        }
    }
}
