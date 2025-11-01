using System;

namespace MoneyMusicDecimal
{
    public class Money
    {
        private int _whole;
        private int _cents;

        public int Whole
        {
            get => _whole;
            set
            {
                if (value < 0) throw new ArgumentException("Ціла частина не може бути від’ємною.");
                _whole = value;
            }
        }

        public int Cents
        {
            get => _cents;
            set
            {
                if (value < 0 || value > 99) throw new ArgumentException("Копійки повинні бути в межах 0-99.");
                _cents = value;
            }
        }

        public Money(int whole = 0, int cents = 0)
        {
            Whole = whole;
            Cents = cents;
        }

        public void SetAmount(int whole, int cents)
        {
            Whole = whole;
            Cents = cents;
        }

        public void Display(string currency = "грн")
        {
            Console.WriteLine($"{Whole}.{Cents:D2} {currency}");
        }

        public void Add(Money other)
        {
            int totalCents = (Whole + other.Whole) * 100 + (Cents + other.Cents);
            Whole = totalCents / 100;
            Cents = totalCents % 100;
        }

        public void Subtract(Money other)
        {
            int totalCents = (Whole * 100 + Cents) - (other.Whole * 100 + other.Cents);
            if (totalCents < 0) totalCents = 0;
            Whole = totalCents / 100;
            Cents = totalCents % 100;
        }
    }
}
