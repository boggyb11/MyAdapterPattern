using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAdapterPattern
{
    class BankAccount
    {
        private float moneyInAccount;

        public BankAccount()
        {
            InitializeAccount();
        }

        private void InitializeAccount()
        {
            moneyInAccount += 500;
        }

        public float WithdrawMoney(float amountToWithdraw)
        {
            if (moneyInAccount - amountToWithdraw > 0)
            {
                moneyInAccount -= amountToWithdraw;
                return amountToWithdraw;
            }
            else return 0;
        }

        public void AddMoney(float amountToAdd)
        {
            moneyInAccount += amountToAdd;
        }
        
    }
}
