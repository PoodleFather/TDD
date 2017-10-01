using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDD.Currency
{
    public class Dollar
    {
        private int Amount { get; set; }

        public Dollar(int amount)
        {
            Amount = amount;
        }
        
        public Dollar Times(int multipler)
        {
            return new Dollar(Amount * multipler);
        }
        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar)obj;
            return Amount == dollar.Amount;
        }
    }
}
