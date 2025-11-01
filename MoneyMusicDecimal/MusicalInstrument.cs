using System;

namespace MoneyMusicDecimal
{
    public class MusicalInstrument
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string HistoryInfo { get; protected set; }

        public MusicalInstrument(string name, string desc, string history)
        {
            Name = name;
            Description = desc;
            HistoryInfo = history;
        }

        public virtual void Show() => Console.WriteLine($"Інструмент: {Name}");
        public virtual void Desc() => Console.WriteLine($"Опис: {Description}");
        public virtual void History() => Console.WriteLine($"Історія: {HistoryInfo}");
    }

    public class Violin : MusicalInstrument
    {
        public Violin() : base("Скрипка", "Струнний інструмент", "Виникла у 16 столітті") { }
    }

    public class Trombone : MusicalInstrument
    {
        public Trombone() : base("Тромбон", "Духовий інструмент", "Відомий з 15 століття") { }
    }

    public class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Укулеле", "Струнний інструмент", "З’явився у Гаваях в 19 столітті") { }
    }

    public class Cello : MusicalInstrument
    {
        public Cello() : base("Віолончель", "Струнний інструмент", "Відомий з 16 століття") { }
    }
}
