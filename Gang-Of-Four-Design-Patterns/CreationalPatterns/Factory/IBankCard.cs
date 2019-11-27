using System;
using System.Collections.Generic;
using System.Text;

namespace Gang_Of_Four_Design_Patterns.CreationalPatterns.Factory
{
    /// <summary>
    /// Interface declares the operations that all concrete bank card classes must implement.
    /// </summary>
    public interface IBankCard
    {
        public float CheckBalance();
        public void Deposit(float sum);
        public void Withdraw(float sum);
        public void Purchase(float price);
    }
}
