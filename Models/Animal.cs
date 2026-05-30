using System;
using System.Collections.Generic;
using System.Text;

namespace BPO1._3.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; }
        public float Weight { get; set; }

        protected Animal(string name, int age, float weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        /// <summary>
        /// Абстрактный метод для реализации в наследниках
        /// </summary>
        public abstract void MakeSound();

        public virtual void AnimalInfo()
        {
            Console.WriteLine($"Класс: {GetType().Name}");
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Вес: {Weight} кг");
        }

        ~Animal()
        {
            Console.WriteLine($"{Name} Прошел мимо шаурмечной");
            if (Age >= 6 | Weight <= 50)
            {
                Console.WriteLine($"{Name} - Вернулся с прогулки");
            }
            else
            {
                Console.WriteLine($"Джамшут пригрел на вертиле {Name}");
            }

        }
    }
}
