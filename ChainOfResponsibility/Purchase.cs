using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Purchase
    {
        public double Amount { get; internal set; }
        public int Number { get; internal set; }

        public string Purpose { get; set; }

        public Purchase(int number, double amount, string purpose)
        {
            Amount = amount;
            Number = number;
            Purpose = purpose;
        }
    }
}
