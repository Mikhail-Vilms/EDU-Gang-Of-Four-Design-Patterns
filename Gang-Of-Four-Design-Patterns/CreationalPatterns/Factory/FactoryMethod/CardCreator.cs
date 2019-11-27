using System;
using System.Collections.Generic;
using System.Text;

namespace Gang_Of_Four_Design_Patterns.CreationalPatterns.Factory.FactoryMethod
{
    /// <summary>
    /// The Creator class declares the factory method that is supposed to return
    /// an object of a IBankCard class. The Creator's subclasses usually provide
    /// the implementation of this method.
    /// </summary>
    public abstract class CardCreator
    {
        /// <summary>
        /// Factory method.
        /// Note that the Creator may also provide some default implementation of the factory method.
        /// </summary>
        public abstract IBankCard CreateCard();

        /// <summary>
        /// Additional method with some buisness logic.
        /// Despite its name, the Creator's primary responsibility is not creating products. 
        /// Usually, it contains some core business logic that relies on Product objects, 
        /// returned by the factory method. Subclasses can indirectly change that business logic 
        /// by overriding the factory method and returning a different type of product from it.
        /// </summary>
        public IBankCard CreateAndSetInitialDeposit(float initialDeposit)
        {
            IBankCard newCard = CreateCard();
            
            newCard.Deposit(initialDeposit);
            
            return newCard;
        }
    }
}
