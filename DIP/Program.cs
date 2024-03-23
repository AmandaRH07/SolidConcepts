using DIP.Payment;
using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcess payment = new PaymentProcess();
            payment.Pay("ABC123");

            Console.ReadLine();
        }
    }
}
