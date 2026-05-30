using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BPO1._3.Models
{
    public abstract class Ungulates : Animal
    {
        public bool Artiodactyl {get;}
        
        protected Ungulates(string name, int age, float weight, bool artiodactyl):base(name, age, weight) 
        {
            Artiodactyl = artiodactyl;
        }

        public override void AnimalInfo()
        {
            base.AnimalInfo();
            Console.WriteLine($"Парнокопытное: {(Artiodactyl ? "да" : "нет")}");
        }

        /// <summary>
        /// Деструктор промежуточного абстрактного класса.
        /// </summary>
        ~Ungulates()
        {
            
        }
    }
}
