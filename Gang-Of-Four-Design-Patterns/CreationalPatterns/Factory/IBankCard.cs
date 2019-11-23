using System;
using System.Collections.Generic;
using System.Text;

namespace Gang_Of_Four_Design_Patterns.CreationalPatterns.Factory
{
    public interface IBankCard
    {
        public void Deposit(float sum);
        public void Withdraw(float sum);
        public void Purchase(float price);
    }
}
