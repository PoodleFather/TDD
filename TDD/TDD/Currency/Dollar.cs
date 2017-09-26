using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDD.Currency
{
    public class Dollar
    {
        private int v;

        public Dollar(int v)
        {
            this.v = v;
        }

        public int Amount { get; set; }

        public void Times(int v)
        {
            throw new NotImplementedException();
        }
    }
}
