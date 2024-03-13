using System;

namespace LSP.Payments
{
    abstract class NubankCard : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine( "Pagamento feito!");
        }

        public virtual void Validate()
        {
            // validação basica do cartão
        }
    }
}
