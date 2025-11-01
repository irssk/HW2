using System;

namespace MoneyMusicDecimal
{
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void IncreasePrice(Money amount) => Price.Add(amount);
        public void DecreasePrice(Money amount) => Price.Subtract(amount);

        public void Show()
        {
            Console.Write($"{Name}: ");
            Price.Display();
        }
    }
}
