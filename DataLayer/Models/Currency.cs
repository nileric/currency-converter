using System;
using System.ComponentModel.DataAnnotations;

namespace currency_converter.Repository
{
    public class Currency
    {
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastUpdate { get; set; }

        public Currency(string charCode, int nominal, string name, double value, DateTime lastUpdate)
        {
            CharCode = charCode;
            Nominal = nominal;
            Name = name;
            Value = value;
            LastUpdate = lastUpdate;
        }
    }
}