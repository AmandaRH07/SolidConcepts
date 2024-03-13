using LSP.Payments;
using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreditCard card = new CreditCard();

            NubanckRewards card = new NubanckRewards();
            card.Validate();
            card.CollectPayment();

            Console.ReadLine();
        }
    }
}
