﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gang_Of_Four_Design_Patterns.CreationalPatterns.Factory
{
    /// <summary>
    /// Provides implementation of the IBankCard interface.
    /// </summary>
    public class DebitCard : IBankCard
    {
        public float _balance;

        public DebitCard(float balance = 0)
        {
            _balance = balance;
        }

        public float CheckBalance()
        { 
            return _balance;
        }

        public void Deposit(float amount)
        {
            _balance += amount;
            System.Console.WriteLine($"Deposit: {amount}$. Balance: {_balance}$");
        }

        public void Purchase(float price)
        {
            Withdraw(price);
            System.Console.WriteLine($"Purchase: {price}.");
        }

        public void Withdraw(float amount)
        {
            if (0 > _balance - amount)
            {
                System.Console.WriteLine($"Unsuccessful attempt to withdraw {amount}$ from credit card." +
                    $"Current balance for this card: {_balance}");
            }
            _balance -= amount;
            System.Console.WriteLine($"{amount}$ has been withdrawn. Balance: {_balance}$");
        }
    }
}
