using System;

namespace BPO1._3.Models
{
    /// <summary>
    /// Интерфейс, описывающий общие члены для животных.
    /// </summary>
    public interface IAnimal
    {
        string Name { get; set; }
        int Age { get; }
        float Weight { get; set; }

        void MakeSound();
        void AnimalInfo();
    }
}