using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Approver
{
    interface IApprover
    {
        IApprover Successor { get; set; }
        void ProcessRequest(Purchase purchase);
    }


}
