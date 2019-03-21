using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAdapterPattern
{
    class DebitCard : BankAccount, ITarget
    {
        public float GetAmount(float amount)
        {
            return WithdrawMoney(amount);
        }
    }
}
