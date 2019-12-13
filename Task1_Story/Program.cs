using System;
using System.Collections.Generic;
using System.Threading;

namespace Task1_Story
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); 
            bool flag = true;
            Mouse mouse = new Mouse("Мыша", 2);
            Frog frog = new Frog("Лягушка", 3);
            Hedgehog hedgehog = new Hedgehog("Ёж", 5);
            Bunny bunny = new Bunny("Зайчик", 7);
            Fox fox = new Fox("Лисичка", 10);
            Bear bear = new Bear("Медведь", 30);

            List<Animal> animals = new List<Animal> { mouse, frog, hedgehog, bunny, fox, bear };
            Shuffle(animals, rnd);

            Console.WriteLine($"Подумал {animals[0].GetName()}: \"Надоело мне в норке жить\"");
            Thread.Sleep(1000);
            Console.WriteLine("Из веточек и щепок построил он себе домик.");
            Thread.Sleep(1000);
            Console.WriteLine("Красивый дом получился.Настоящий теремок.");
            Thread.Sleep(1000);
            Console.WriteLine($" Стал {animals[0].GetName()} в нём  жить.");
            Thread.Sleep(1000);
            animals[0].GiveButtleRoar();
            Thread.Sleep(1000);
            House house = animals[0].BuildHouse(rnd.Next(60, 100));
            house.AddAnimal(animals[0]);
            Thread.Sleep(1000);
            
            foreach (var animal in animals)
            {
                if (flag)   //пропуск первого животного
                {
                    flag = false;
                    continue;
                }
                Console.WriteLine($"Скачет мимо {animal.GetName()}. Остановилась и спрашивает:");
                Thread.Sleep(1000);
                animal.AskWhoLives();
                Thread.Sleep(1000);

                foreach (var roomer in house.roomers) // Приветствие всех жителей теремка
                {
                    roomer.GiveButtleRoar();
                    Thread.Sleep(1000);
                }

                animals[0].AskName();
                Thread.Sleep(1000);
                animal.GiveButtleRoar();
                Thread.Sleep(1000);
                animals[0].Invite();
                house.AddAnimal(animal);
                Thread.Sleep(1000);
            }
            
            Console.ReadLine();

            void Shuffle(List<Animal> _A, Random _rnd) // перетасовка списка
            {
                for (int i = 0; i < _A.Count; i++)
                {
                    var tmp = _A[0];
                    _A.RemoveAt(0);
                    _A.Insert(_rnd.Next(_A.Count), tmp);
                }
            }
        }
    }
}
