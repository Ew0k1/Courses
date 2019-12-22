using System;

namespace Task1_Story
{
    abstract class Animal:IButtleRoar
    {
        public string Name { get; set; }
       

        public Animal(string _name, int _size)
        {
            Name = _name;
            Size = _size;
        }
        public Animal() { }
        public abstract string Kind { get; }
        public abstract string Gender { get; }
        public abstract int MaxSize { get; }
        public abstract int Size { get; set; }

        public abstract void GiveButtleRoar(); // Приветствие

        public virtual void Invite()
        {
            Console.WriteLine("Иди к нам жить!");
        }
        public virtual void ChangeHouseCapacity()
        {
            Console.WriteLine("Давайте увеличим теремок!");
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
            Console.WriteLine($"Прыгнул {Name} в теремок.");
        }
        
       
       
        
    }
}
