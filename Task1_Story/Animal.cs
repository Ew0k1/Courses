using System;

namespace Task1_Story
{
    abstract class Animal
    {
        protected string name;

        protected int size;

        public Animal(string _name, int _size)
        {
            name = _name;
            size = _size;
        }

        public abstract void GiveButtleRoar(); // Приветствие

        public virtual void Invite()
        {
            Console.WriteLine("Иди к нам жить!");
        }
        public virtual void AskWhoLives()
        {
            Console.WriteLine("Терем-теремок! Кто в тереме живёт?");
        }
        public virtual void AskName()
        {
            Console.WriteLine("А ты кто?");
        }
        public virtual House BuildHouse(int _size)
        {
            return new House(_size);
        }
        public virtual void ConfirmInvite()
        {
            Console.WriteLine($"Прыгнул {name} в теремок.");
        }
        public int GetSize()
        {
            return size;
        }
        public string GetName()
        {
            return name;
        }
    }
}
