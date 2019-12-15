using System;
using System.Collections.Generic;
using System.Threading;

namespace Task1_Story
{
    class House
    {
        private const int delay = 500;
        private int houseCapacity;
        private int roomersSize;
        public List<Animal> roomers { get; set; } = new List<Animal>();
        public House(int _size)
        {
            houseCapacity = _size;
        }

        public void AddAnimal(Animal _animal)
        {
            if((roomersSize + _animal.GetSize())>=houseCapacity)
            {
                HouseOverflow(_animal);
                DestroyHouse();
                BuildNewHouse();
                throw new HouseException("Сказочке конец");
            }
            else
            {
                roomers.Add(_animal);
                roomersSize += _animal.GetSize();
            }
            if (roomers.Count == 6)
            {
                HappyEnd();
                throw new HouseException("Сказочке конец");
            }
        }

        public void DestroyHouse()
        {
            Console.WriteLine("Тут теремок упал набок да и развалился...");
        }

        public void HouseOverflow(Animal _animal)
        {
            Console.WriteLine($"Полез {_animal.GetName()} в теремок. Лез-лез в дверь - - никак влезть не может. Лез-лез в окно — никак влезть не может. ");
            Thread.Sleep(delay);
            Console.Write($"Влез {_animal.GetName()} на крышу. Затрещал теремок, закачался. Выскочили из него ");
           
            foreach (var item in roomers)
            {
                Console.Write(item.GetName() + " ");
            }
            Console.WriteLine();
            Thread.Sleep(delay);
            
        }

        public void BuildNewHouse()
        {
            Console.WriteLine("Подумали звери да и решили новый дом построить.");
            Thread.Sleep(delay);
            Console.WriteLine("Стали они брёвна таскать, доски пилить, гвозди забивать.");
            Thread.Sleep(delay);
            Console.WriteLine("Хороший теремок получился: большой, красивый, куда лучше прежнего.");
            Thread.Sleep(delay);
            Console.WriteLine("Всем в нём места хватило.");
            houseCapacity += 50;
        }

        public void HappyEnd()
        {
            Console.WriteLine("Большой теремок получился. Все звери поместились. И жили они вместе долго и счастливо!");
        }

    }
}
