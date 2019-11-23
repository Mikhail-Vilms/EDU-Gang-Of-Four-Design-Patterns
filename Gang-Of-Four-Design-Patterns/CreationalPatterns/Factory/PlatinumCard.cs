using System;
using System.Collections.Generic;
using System.Text;

namespace Gang_Of_Four_Design_Patterns.CreationalPatterns.Factory
{
    class PlatinumCard : IBankCard
    {
        private float _balance;
        private float _cashBackRate;

        public PlatinumCard(float balance, float cashBackRate)
        {
            _balance = balance;
            _cashBackRate = cashBackRate;
        }

        public void Deposit(float amount)
        {
            _balance = -amount;
            System.Console.WriteLine($"Deposit: {amount}$. Balance: {_balance}$");
        }

        public void Purchase(float price)
        {
            Withdraw(price * (1 - _cashBackRate));
            System.Console.WriteLine($"Purchase: {price}. Cashback: {_cashBackRate}");
        }

        public void Withdraw(float amount)
        {
            _balance = -amount;
            System.Console.WriteLine($"{amount}$ has been withdrawn. Balance: {_balance}$");
        }
    }
}
