using System;
using Bank.Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank.Test
{
    [TestClass]
    public class BankTests
    {
        [TestMethod]
        public void Test1()
        {
            // arrange
            int amount = 100;
            int payment = 100;
            int expected = 0;
            var bankAccount = new BankAccount(amount);

            // act
            bankAccount.Withdraw(payment);

            // assert
            Assert.AreEqual(expected, bankAccount.Balance, "AAA.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test2()
        {
            // arrange
            int amount = 100;
            int payment = 200;
            var bankAccount = new BankAccount(amount);

            // act
            bankAccount.Withdraw(payment);

            // assert
        }
    }
}
