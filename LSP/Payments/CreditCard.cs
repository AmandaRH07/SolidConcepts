using System;

namespace LSP.Payments
{
    class CreditCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando o saldo da conta ...");
            Console.WriteLine("Saldo disponível!");
        }
    }
}
