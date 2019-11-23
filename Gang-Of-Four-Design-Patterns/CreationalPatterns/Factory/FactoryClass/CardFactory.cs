using System;
using System.Collections.Generic;
using System.Text;

namespace Gang_Of_Four_Design_Patterns.CreationalPatterns.Factory.FactoryClass
{
    /// <summary>
    /// Implementation of Factory - Used to create objects
    /// </summary>
    public class CardFactory
    {
        public IBankCard GetBankCard(CardType cardType)
        {
            switch (cardType)
            {
                case CardType.Platinum:
                    return new PlatinumCard(500, (float)0.2);
                case CardType.Credit:
                    return new CreditCard(500, -500, (float)0.1);
                case CardType.Debit:
                    return new DebitCard(500);
                default:
                    throw new NotSupportedException();

            }
        }
    }
}
