using System;
using System.Collections.Generic;
using System.Threading;

namespace Task1_Story
{
    delegate void HouseHandler(string message);
    class House
    {
        private const int delay = 500;
        private int houseCapacity;
        private int roomersSize;
        public event HouseHandler Changed;
        public event HouseHandler Built;
        public event HouseHandler Ended;
        public List<Animal> roomers { get; set; } = new List<Animal>();
        public House(int _size)
        {
            houseCapacity = _size;
        }

        public int GetHouseCapacity()
        {
            return houseCapacity;
        }
        public void AddAnimal(Animal _animal)
        {
            if((roomersSize + _animal.Size)>=houseCapacity)
            {
                HouseOverflow(_animal);
                DestroyHouse();
                BuildNewHouse();
                throw new HouseException("Сказочке конец");
            }
            else
            {
                roomers.Add(_animal);
                roomersSize += _animal.Size;
            }
            //if (roomers.Count == 6)
            //{
            //    HappyEnd();
            //    throw new HouseException("Сказочке конец");
            //}
        }

        public void DestroyHouse()
        {
            Console.WriteLine("Тут теремок упал набок да и развалился...");
        }

        public void HouseOverflow(Animal _animal)
        {
            Console.WriteLine($"Полез {_animal.Name} в теремок. Лез-лез в дверь - - никак влезть не может. Лез-лез в окно — никак влезть не может. ");
            Thread.Sleep(delay);
            Console.Write($"Влез {_animal.Name} на крышу. Затрещал теремок, закачался. Выскочили из него ");
           
            foreach (var item in roomers)
            {
                Console.Write(item.Name + " ");
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
            houseCapacity += 200;
            Built?.Invoke($"Теремок стал размером в {houseCapacity} единиц");
            Console.WriteLine("Всем в нём места хватило.");
        }

        public void ChangeCapacity(int _capacity )
        {
            houseCapacity += _capacity;
            Changed?.Invoke($"Теремок увеличился на {_capacity} единиц");
        }

        public void HappyEnd()
        {
            Console.WriteLine("Большой теремок получился. Все звери поместились. И жили они вместе долго и счастливо!");
            Ended?.Invoke("Ура, товарищи!!!");
        }

    }
}
