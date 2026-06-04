using System;
using System.Collections.Generic;
using BPO1._3.Models;

class Program
{
    static void Main()
    {
        var animals = new List<Animal>();

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1 - Добавить животное ");
            Console.WriteLine("2 - Вывести все характеристики и звуки");
            Console.WriteLine("3 - Уничтожить всех животных (очистить список)");
            Console.WriteLine("0 - Выход");
            Console.Write("Ваш выбор: ");

            var input = Console.ReadLine()?.Trim();

            switch (input)
            {
                case "1":
                    var newAnimal = CreateAnimalInteractively();
                    if (newAnimal != null)
                    {
                        animals.Add(newAnimal);
                        Console.WriteLine($"Животное '{newAnimal.Name}' добавлено в список.");
                    }
                    break;

                case "2":
                    if (animals.Count == 0)
                    {
                        Console.WriteLine("Список пуст. Сначала создайте животных (выберите 1).");
                    }
                    else
                    {
                        Console.WriteLine("\nВсе животные:");
                        foreach (var a in animals)
                        {
                            a.AnimalInfo();
                            a.MakeSound();
                            Console.WriteLine();
                        }
                    }
                    break;

                case "3":
                    if (animals.Count == 0)
                    {
                        Console.WriteLine("Список уже пуст.");
                    }
                    else
                    {
                        animals.Clear();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        Console.WriteLine("Все животные уничтожены (список очищен, сборка мусора вызвана).");
                    }
                    break;

                case "0":
                    Console.WriteLine("Нажмите любую клавишу для выхода...");
                    Console.ReadKey(true);
                    return;

                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    #region Интерактивный ввод
    static Animal? CreateAnimalInteractively()
    {
        Console.WriteLine("\nВыберите тип животного:");
        Console.WriteLine("1 - Собака (Dog)");
        Console.WriteLine("2 - Кот (Cat)");
        Console.WriteLine("3 - Корова (Cow)");
        Console.WriteLine("4 - Лошадь (Horse)");
        Console.Write("Введите номер: ");

        var type = Console.ReadLine()?.Trim();

        Console.Write("Имя: ");
        string name = Console.ReadLine()?.Trim() ?? "Безымянный";
        int age = ReadInt("Возраст (лет): ");
        float weight = (float)ReadDouble("Вес (кг): ");

        try
        {
            switch (type)
            {
                case "1":
                    Console.Write("Порода: ");
                    string breed = Console.ReadLine()?.Trim() ?? "Дворняга";
                    return new Dog(name, age, weight, breed);

                case "2":
                    Console.Write("Окрас: ");
                    string color = Console.ReadLine()?.Trim() ?? "Рыжая";
                    return new Cat(name, age, weight, color);

                case "3":
                    bool Artiodactyl = true;
                    double milk = ReadDouble("Удой (литров/день): ");
                    return new Cow(name, age, weight, Artiodactyl, (float)milk);

                case "4":
                    bool Artiodactyl_Hose = false;
                    double speed = ReadDouble("Скорость (км/ч): ");
                    return new Horse(name, age, weight, Artiodactyl_Hose, (float)speed);

                default:
                    Console.WriteLine("❌ Неверный тип животного.");
                    return null;
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка валидации: {ex.Message}");
            return null;
        }
    
    }

    static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                if (result > 0) return result;
                Console.WriteLine("Ошибка: число должно быть больше нуля.");
            }
            else
            {
                Console.WriteLine("Ошибка: введите целое число.");
            }
        }
    }

    static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                if (result > 0) return result;
                Console.WriteLine("Ошибка: число должно быть больше нуля.");
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное число.");
            }
        }
    }

    static bool ReadBool(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            var input = Console.ReadLine()?.Trim().ToLower();
            if (input == "да" || input == "y" || input == "1") return true;
            if (input == "нет" || input == "n" || input == "0") return false;
            Console.WriteLine(" Ответьте: да / нет (или y / n).");
        }
    }
    #endregion
}