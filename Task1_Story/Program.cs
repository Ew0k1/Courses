using System;
using System.Collections.Generic;
using System.Threading;

namespace Task1_Story
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Mouse mouse = new Mouse("Мыша", 2);
            //Frog frog = new Frog("Лягушка", 3);
            //Hedgehog hedgehog = new Hedgehog("Ёж", 5);
            //Bunny bunny = new Bunny("Зайчик", 7);
            //Fox fox = new Fox("Лисичка", 10);
            //Bear bear = new Bear("Медведь", 30);
            //foreach (var item in animals)
            //{
            //    Console.Write(item.Name +  " ");
            //    Console.WriteLine(item.Kind);
            //}
            #endregion
            Generator<Mouse> mouses = new Generator<Mouse>(2);
            Generator<Frog> frogs = new Generator<Frog>(2);
            Generator<Hedgehog> hedgehogs = new Generator<Hedgehog>(2);
            Generator<Bunny> bunny = new Generator<Bunny>(2);
            Generator<Fox> fox = new Generator<Fox>(2);
            Generator<Bear> bear = new Generator<Bear>(2);

            List<Animal> animals = new List<Animal>();
            animals.AddRange(mouses.GetAnimals());
            animals.AddRange(frogs.GetAnimals());
            animals.AddRange(hedgehogs.GetAnimals());
            animals.AddRange(bunny.GetAnimals());
            animals.AddRange(fox.GetAnimals());
            animals.AddRange(bear.GetAnimals());

            StoryController story = new StoryController(animals);

            story.TellTheBeginning();

            story.TellTheMainPart();


            Console.ReadLine();

           
        }
    }
    
        
}
