using System;
using System.Collections.Generic;
using System.Text;

namespace BPO1._3.Models
{
    internal class Dog: Animal
    {
        public string Breed { get; set; }
        public Dog(string name, int age, float weight, string breed) : base(name, age, weight)
        {
            Breed = breed;
        }

        public override void AnimalInfo()
        {
            base.AnimalInfo();
            Console.WriteLine($"Порода: {Breed}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Гав!");
        }       
    
    }
}
