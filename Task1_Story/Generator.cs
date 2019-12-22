using System;
using System.Collections.Generic;

namespace Task1_Story
{
    class Generator<T> where T: Animal, new()
    {
        private static readonly Random random = new Random();

        List<string> maleNames = new List<string>() {"Эдуард","Леонид","Александр","Владимир","Станислав","Сергей","Денис","Виктор","Антон","Алексей"};
        List<string> femaleNames = new List<string>() { "Мария", "Дарья", "Полина", "Кристина", "Анастасия", "Ирина", "Юлия", "Елена", "Татьяна", "Лариса"};
        List<T> animals = new List<T>();
        public Generator(int _count)
        {
            for (int i = 0; i < _count; i++)
            {
                var animal = new T();
                animal.Name = GenerateRandomName(animal.Gender);
                animal.Size = GenerateRandomDigit(1, animal.MaxSize);
                animals.Add(animal);
            }
        }

        public List<T> GetAnimals()
        {
            return animals;
        }

        public List<TAnimal> GetAnimal<TAnimal>() where TAnimal: Animal
        {
            List<TAnimal> animals = new List<TAnimal>();
            foreach (var animal in animals)
            {
                if (animal is TAnimal)
                {
                    animals.Add(animal as TAnimal);
                }
            }
            return animals;
        }
        private void Shuffle(List<Animal> list) // перетасовка списка
        {
            for (int i = list.Count - 1; i >= 1; i--)
            {
                int j = GenerateRandomDigit(i + 1);

                var tmp = list[j];
                list[j] = list[i];
                list[i] = tmp;
            }
        }
        static int GenerateRandomDigit(int _start, int _end)
        {
            return random.Next(_start, _end);
        }
        static int GenerateRandomDigit(int _end)
        {
            return random.Next(_end);
        }
        string GenerateRandomName(string _gender)
        {
            string result = string.Empty;
            if (_gender == "мужской")
            {
                int index = GenerateRandomDigit(maleNames.Count);
                result = maleNames[index];
            }
            else if(_gender == "женский")
            {
                int index = GenerateRandomDigit(femaleNames.Count);
                result = femaleNames[index];
            }
             return result;
        }
        
    }
}
