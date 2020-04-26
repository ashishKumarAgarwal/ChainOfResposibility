using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Approver
{
    class President : IApprover
    {
        public IApprover Successor { get; set; }
        public void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request# {purchase.Number}");
            }
            else
            {
                Console.WriteLine($"Request# {purchase.Number} requires an executive meeting!");
            }
        }
    }
}
