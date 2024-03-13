using System;

namespace LSP.Payments
{
    class NubanckRewards : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso!");
            Console.WriteLine("Pontuação creditada");
        }

        public void Validate()
        {
            Console.WriteLine("Limite Ok, Rewards OK!");
        }
    }
}
