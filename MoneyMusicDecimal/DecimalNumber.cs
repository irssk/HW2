using System;

namespace MoneyMusicDecimal
{
    public struct DecimalNumber
    {
        public int Value { get; set; }

        public DecimalNumber(int value)
        {
            Value = value;
        }

        public string ToBinary() => Convert.ToString(Value, 2);
        public string ToOctal() => Convert.ToString(Value, 8);
        public string ToHex() => Convert.ToString(Value, 16).ToUpper();
    }
}
