using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Approver
{
    class Director : IApprover
    {
        public IApprover Successor { get; set; }
        public void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request# {purchase.Number}");
            }
            else if (Successor != null)
            {
                Successor.ProcessRequest(purchase);
            }
        }
    }
}
