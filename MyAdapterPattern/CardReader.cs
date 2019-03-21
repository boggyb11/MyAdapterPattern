using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAdapterPattern
{
    //Client
    class CardReader
    {
        private ITarget moneySource;

        public CardReader(ITarget moneySource)
        {
            this.moneySource = moneySource;
        }

        public void TakePayment(float amount)
        {
            var paymentAmount = moneySource.GetAmount(amount);
            Console.WriteLine($"Payment of £{paymentAmount} received!!");
        }

    }
}
