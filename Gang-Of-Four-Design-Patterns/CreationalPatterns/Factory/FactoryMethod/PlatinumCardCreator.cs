using System;
using System.Collections.Generic;
using System.Text;

namespace Gang_Of_Four_Design_Patterns.CreationalPatterns.Factory.FactoryMethod
{
    /// <summary>
    /// Concrete creator class overrides the factory method in order to change the result type.
    /// </summary>
    public class PlatinumCardCreator : CardCreator
    {
        public override IBankCard CreateCard()
        {
            return new PlatinumCard(0, (float)0.2);
        }
    }
}
