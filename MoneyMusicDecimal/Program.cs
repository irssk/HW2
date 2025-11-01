using System;
using System.Collections.Generic;

namespace MoneyMusicDecimal
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Виберіть завдання:");
                Console.WriteLine("1 - Гроші та товар");
                Console.WriteLine("2 - Музичні інструменти");
                Console.WriteLine("3 - Десяткове число");
                Console.WriteLine("0 - Вихід");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Task1(); break;
                    case "2": Task2(); break;
                    case "3": Task3(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Некоректний вибір. Спробуйте ще раз.");
                        break;
                }

                Console.WriteLine("\nНажміть Enter, щоб повернутися в меню...");
                Console.ReadLine();
            }
        }

        // --- Task 1 ---
        static void Task1()
        {
            Product apple = new Product("Яблуко", new Money(10, 50));

            while (true)
            {
                Console.WriteLine("\nМеню завдання 1:");
                Console.WriteLine("1 - Показати продукт");
                Console.WriteLine("2 - Збільшити ціну");
                Console.WriteLine("3 - Зменшити ціну");
                Console.WriteLine("0 - Назад");

                string choice = Console.ReadLine();
                if (choice == "0") break;

                switch (choice)
                {
                    case "1": apple.Show(); break;
                    case "2":
                        Console.Write("Гривні: "); int w = int.Parse(Console.ReadLine());
                        Console.Write("Копійки: "); int c = int.Parse(Console.ReadLine());
                        apple.IncreasePrice(new Money(w, c));
                        break;
                    case "3":
                        Console.Write("Гривні: "); w = int.Parse(Console.ReadLine());
                        Console.Write("Копійки: "); c = int.Parse(Console.ReadLine());
                        apple.DecreasePrice(new Money(w, c));
                        break;
                }
            }
        }

        // --- Task 2 ---
        static void Task2()
        {
            List<MusicalInstrument> orchestra = new List<MusicalInstrument>()
            {
                new Violin(), new Trombone(), new Ukulele(), new Cello()
            };

            foreach (var instr in orchestra)
            {
                instr.Show();
                instr.Desc();
                instr.History();
                Console.WriteLine();
            }
        }

        // --- Task 3 ---
        static void Task3()
        {
            Console.Write("Введіть число: ");
            int number = int.Parse(Console.ReadLine());
            DecimalNumber dec = new DecimalNumber(number);

            while (true)
            {
                Console.WriteLine("\nМеню завдання 3:");
                Console.WriteLine("1 - Двійкова");
                Console.WriteLine("2 - Вісімкова");
                Console.WriteLine("3 - Шістнадцяткова");
                Console.WriteLine("0 - Назад");

                string choice = Console.ReadLine();
                if (choice == "0") break;

                switch (choice)
                {
                    case "1": Console.WriteLine($"Бінарний: {dec.ToBinary()}"); break;
                    case "2": Console.WriteLine($"Вісімковий: {dec.ToOctal()}"); break;
                    case "3": Console.WriteLine($"Шістнадцятковий: {dec.ToHex()}"); break;
                }
            }
        }
    }
}
