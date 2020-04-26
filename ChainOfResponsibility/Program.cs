using System;
using ChainOfResponsibility.Approver;

namespace ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IApprover director = new Director();
            IApprover vicePresident = new VicePresident();
            IApprover president = new President();

            director.Successor = vicePresident;
            vicePresident.Successor = president;

            Purchase p = new Purchase(8884, 350, "Assets");
            director.ProcessRequest(p);
            Purchase p1 = new Purchase(5675, 33390, "Project Poison");
            director.ProcessRequest(p1);
            Purchase p2 = new Purchase(5676, 144400, "Project BBD");
            director.ProcessRequest(p2);


            Console.ReadKey();

        }
    }

    //Handler


    //internal class Director : Approver
    //{
    //    public override void ProcessRequest(Purchase purchase)
    //    {
    //        if (purchase.Amount < 10000.0)
    //        {
    //            Console.WriteLine($"{this.GetType().Name} approved request# {purchase.Number}");
    //        }
    //        else if (Successor != null)
    //        {
    //            Successor.ProcessRequest(purchase);
    //        }
    //    }
    //}

    //internal class VicePresident : Approver
    //{
    //    public override void ProcessRequest(Purchase purchase)
    //    {
    //        if (purchase.Amount < 25000.0)
    //        {
    //            Console.WriteLine($"{this.GetType().Name} approved request# {purchase.Number}");
    //        }
    //        else if (Successor != null)
    //        {
    //            Successor.ProcessRequest(purchase);
    //        }
    //    }
    //}

    //internal class President : Approver
    //{
    //    public override void ProcessRequest(Purchase purchase)
    //    {
    //        if (purchase.Amount < 100000.0)
    //        {
    //            Console.WriteLine($"{this.GetType().Name} approved request# {purchase.Number}");
    //        }
    //        else
    //        {
    //            Console.WriteLine($"Request# {purchase.Number} requires an executive meeting!");
    //        }
    //    }
    //}

    //public class Purchase
    //{
    //    public double Amount { get; internal set; }
    //    public int Number { get; internal set; }

    //    public string Purpose { get; set; }

    //    public Purchase(int number, double amount, string purpose)
    //    {
    //        Amount = amount;
    //        Number = number;
    //        Purpose = purpose;
    //    }
    //}
}