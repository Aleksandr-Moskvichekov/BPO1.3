using System;
using System.Collections.Generic;
using System.Text;

namespace BPO1._3.Models
{
    internal class Cow: Ungulates
    {
        public double MilkProduction { get; set; } 
        public Cow(string name, int age, float weight, bool artiodactyl, double milkProduction) : base(name, age, weight, artiodactyl)
        {
            MilkProduction = milkProduction;
        }

        public override void AnimalInfo()
        {
            base.AnimalInfo();
            Console.WriteLine($"Производство молока: {MilkProduction} литров в день");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Му!");
        }
    }
}
