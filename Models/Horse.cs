using System;
using System.Collections.Generic;
using System.Text;

namespace BPO1._3.Models
{
    internal class Horse: Ungulates
    {
        public double Speed { get; }
        public Horse(string name, int age, float weight, bool artiodactyl, double speed) : base(name, age, weight, artiodactyl)
        {
            Speed = speed;
        }

        public override void AnimalInfo()
        {
            base.AnimalInfo();
            if(Speed > 200) Console.WriteLine($"суперскоросная лошадь");
            Console.WriteLine($"Скорость: {Speed} км/ч");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Иго-го!");
        }   
    
    }
}
