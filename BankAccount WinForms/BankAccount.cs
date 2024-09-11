using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_WinForms
{
    public class BankAccount
    {

        int balance = 0;

        public void Deposit(int amount)
        {


            balance += amount;

        }

        public void Withdraw(int amount)
        {
            if (balance > (amount -1))
            {
                balance -= amount;
            }

        }


        public int GetBalance()
        {

            return balance;

        }

    }
}
