using System;
using System.Collections.Generic;
using System.Text;

namespace BPO1._3.Models
{
    internal class Cat: Animal
    {
        public string Color { get; set; }
        public Cat(string name, int age, float weight, string color) : base(name, age, weight)
        {
            Color = color;
        }

        public override void AnimalInfo()
        {
            base.AnimalInfo();
            Console.WriteLine($"Цвет: {Color}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Мяу!");
        }
    }
}
