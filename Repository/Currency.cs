using currency_converter.Network;

namespace currency_converter.Repository
{
    public class Currency
    {
        public string CharCode { get; private set; }
        public int Nominal { get; private set; }
        public string Name { get; private set; }
        public double Value { get; private set; }

        public Currency(ValuteResponse valute) : this(valute.CharCode, valute.Nominal, valute.Name, valute.Value)
        {
        }

        public Currency(string charCode, int nominal, string name, double value)
        {
            CharCode = charCode;
            Nominal = nominal;
            Name = name;
            Value = value;
        }
    }
}