using System;
using System.Collections.Generic;
using System.Threading;

namespace Task1_Story
{
    class StoryController
    {
        delegate void StoryHandler(string message);
        private const int delay = 0;
        private Random random = new Random();
        

        bool flag = true;

        List<Animal> animals;
        public House house;

        public StoryController(List<Animal> _animals)
        {
            animals = _animals;
            if (IsMiracleHappened())
            {
                animals.Add(new Dinosaur("Ти-Рекс", 100));
            }
            Shuffle(animals, random);
        }


        public void TellTheBeginning()
        {
            
            try
            {
                if (animals[0].GetType() == typeof(Dinosaur))
                {
                    throw new AnimalException("Оу май, вот это поворот! Случилось чудо! В лесу гуляет динозавр!");
                }
                Console.WriteLine($"Подумал {animals[0].GetName()}: \"Надоело мне в норке жить\"");
                Thread.Sleep(delay);
                Console.WriteLine("Из веточек и щепок построил он себе домик.");
                Thread.Sleep(delay);
                Console.WriteLine("Красивый дом получился.Настоящий теремок.");
                Thread.Sleep(delay);
                Console.WriteLine($"Стал {animals[0].GetName()} в нём  жить.");
                Thread.Sleep(delay);
                animals[0].GiveButtleRoar();
                Thread.Sleep(delay);
                house = animals[0].BuildHouse(random.Next(30, 100));
                house.Changed += DisplayBlueMessage;
                house.Built += DisplayBlueMessage;
                house.Ended += Congratulations;
                house.AddAnimal(animals[0]);
                Thread.Sleep(delay);
               

            }
            catch (AnimalException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Какая сказка? Вы только посмотрите, это же динозавр!");
            }
            catch (HouseException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void TellTheMainPart()
        {
            
            try
            {
                foreach (var animal in animals)
                {
                    if (flag)   //пропуск первого животного
                    {
                        flag = false;
                        continue;
                    }
                    if (animal.GetType()==typeof(Dinosaur))
                    {
                        throw new AnimalException("Случилось чудо! В лесу гуляет динозавр!");
                    }
                    Console.WriteLine($"Скачет мимо {animal.GetName()}. Остановилась и спрашивает:");
                    Thread.Sleep(delay);
                    animal.AskWhoLives();
                    Thread.Sleep(delay);

                    foreach (var roomer in house.roomers) // Приветствие всех жителей теремка
                    {
                        roomer.GiveButtleRoar();
                        Thread.Sleep(delay);
                    }

                    animals[0].AskName();
                    Thread.Sleep(delay);
                    animal.GiveButtleRoar();
                    Thread.Sleep(delay);
                    animals[0].Invite();
                    animal.ConfirmInvite();
                    house.AddAnimal(animal);
                    Thread.Sleep(delay);

                    if (IsMiracleHappened())
                    {
                        animals[0].ChangeHouseCapacity();
                        house.ChangeCapacity(100);
                    }
                    if (IsMiracleHappened())
                    {
                        StarFall("Упала звезда!", delegate(string mes)
                        {
                            int rnd = random.Next(5);
                            for (int i = 0; i < rnd; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(mes);
                                Console.ResetColor();
                            }
                        });
                    }
                    NextDay();
                }

            }
            catch (AnimalException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Он разрушает теремок и бросается на животных");

                foreach (var roomer in house.roomers)
                {
                    if (IsMiracleHappened())
                    {
                        Console.WriteLine($"Динозавру попался {roomer.GetName()}. Когда динозавр его ел, то подавился и умер");
                        break;
                    }
                    Console.WriteLine($"Динозавру попался {roomer.GetName()}. Динозавр съел его");
                }
            }
            catch (HouseException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private bool IsMiracleHappened()
        {
            if (random.Next(0, 10) == 1)
            {
                return true;
            }
            return false;
        }
        private void Shuffle(List<Animal> list, Random _rnd) // перетасовка списка
        {
            for (int i = list.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);

                var tmp = list[j];
                list[j] = list[i];
                list[i] = tmp;
            }
        }
        private static void DisplayBlueMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            // Сбрасываем настройки цвета
            Console.ResetColor();
        }

        private static void Congratulations(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            #region
            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(622, 120);
            Thread.Sleep(130);

            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(622, 120);
            Thread.Sleep(130);
            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(494, 120);
            Thread.Sleep(130);
            Console.Beep(587, 120);
            Thread.Sleep(130);
            Console.Beep(523, 120);
            Thread.Sleep(130);

            Console.Beep(440, 120);
            Thread.Sleep(150);
            Console.Beep(262, 120);
            Thread.Sleep(130);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(440, 120);
            Thread.Sleep(130);

            Console.Beep(494, 120);
            Thread.Sleep(150);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(415, 120);
            Thread.Sleep(130);
            Console.Beep(494, 120);
            Thread.Sleep(130);

            Console.Beep(523, 120);
            Thread.Sleep(150);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(622, 120);
            Thread.Sleep(130);

            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(622, 120);
            Thread.Sleep(130);
            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(494, 120);
            Thread.Sleep(130);
            Console.Beep(587, 120);
            Thread.Sleep(130);
            Console.Beep(523, 120);
            Thread.Sleep(130);

            Console.Beep(440, 120);
            Thread.Sleep(150);
            Console.Beep(262, 120);
            Thread.Sleep(130);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(440, 120);
            Thread.Sleep(130);

            Console.Beep(494, 120);
            Thread.Sleep(150);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(523, 120);
            Thread.Sleep(130);
            Console.Beep(494, 120);
            Thread.Sleep(150);
            Console.Beep(440, 120);
            #endregion
        }

        private static void NextDay() => Console.WriteLine("Наступил следующий день!");
        private static void StarFall(string message, StoryHandler handler)
        {
            Console.WriteLine("Начался звездопад");
            handler(message);
        }
        







    }
}
