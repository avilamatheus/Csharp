using System;
using System.Collections.Generic;
using System.Text;
using ExProp_Exce.Entities.Exceptions;

namespace ExProp_Exce.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount>WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
        }
    }
}
