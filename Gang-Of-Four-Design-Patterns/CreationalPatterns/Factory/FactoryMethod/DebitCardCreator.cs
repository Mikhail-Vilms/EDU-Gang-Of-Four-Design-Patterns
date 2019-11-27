using System;
using System.Collections.Generic;
using System.Text;

namespace Gang_Of_Four_Design_Patterns.CreationalPatterns.Factory.FactoryMethod
{
    /// <summary>
    /// Concrete creator class overrides the factory method in order to change the result type.
    /// </summary>
    public class DebitCardCreator : CardCreator
    {
        public override IBankCard CreateCard()
        {
            return new DebitCard();
        }
    }
}
