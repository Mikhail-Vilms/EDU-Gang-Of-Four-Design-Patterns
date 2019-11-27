using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gang_Of_Four_Design_Patterns.CreationalPatterns.Factory.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gang_Of_Four_Design_Patterns.CreationalPatterns.Factory.FactoryMethod.Tests
{
    [TestClass()]
    public class CardCreatorTests
    {
        DebitCardCreator debitCardCreator;
        CreditCardCreator creditCardCreator;
        PlatinumCardCreator platinumCardCreator;

        [TestInitialize]
        public void testInit()
        {
            debitCardCreator = new DebitCardCreator();
            creditCardCreator = new CreditCardCreator();
            platinumCardCreator = new PlatinumCardCreator();
        }

        [TestMethod()]
        public void CreateCard_UsingDebitCardFactory_ReturnsDebitCardInstance()
        {
            IBankCard debitCard = debitCardCreator.CreateAndSetInitialDeposit(1000);
            debitCard.Purchase(100);
            Assert.AreEqual(900, debitCard.CheckBalance()); 
        }

        [TestMethod()]
        public void CreateCard_UsingCreditCardFactory_ReturnsCreditCardInstance()
        {
            IBankCard creditCard = creditCardCreator.CreateAndSetInitialDeposit(1000);
            creditCard.Purchase(100);
            Assert.AreEqual(910, creditCard.CheckBalance());
        }

        [TestMethod()]
        public void CreateCard_UsingPCardFactory_ReturnsCreditCardInstance()
        {
            IBankCard platinumCard = platinumCardCreator.CreateAndSetInitialDeposit(1000);
            platinumCard.Purchase(100);
            Assert.AreEqual(920, platinumCard.CheckBalance());
        }
    }
}