using DIP.Factory;
using DIP.Model;
using System;

namespace DIP.Payment
{
    class PaymentProcess
    {
        public void Pay(string id)
        {
            DbProduct product = DbProductFactory.Create();
            string productData = product.GetProductById(id);

            Console.WriteLine(productData);
        }
    }
}
