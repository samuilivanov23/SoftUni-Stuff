using System;
using NUnit.Framework;

namespace BankingSystem.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount bankAccount;

        [SetUp]
        public void Setup()
        {
            this.bankAccount = new BankAccount();
        }

        [TestCase(100)]
        [TestCase(200)]
        [TestCase(500)]
        public void DepositShouldIncreaseBalance(int depositAmount)
        {
            //Arrange
            //BankAccount bankAccount = new BankAccount(); not needed because of Setup()

            //Act
            this.bankAccount.Deposit(depositAmount);

            //Assert
            Assert.AreEqual(depositAmount, this.bankAccount.Balance);
        }

        [Test]
        public void NegativeAmountInDepositShouldThrowException()
        {
            //BankAccount bankAccount = new BankAccount(); same
            decimal depositAmount = -100;

            Assert.Throws<InvalidOperationException>(
            () =>
            {
                this.bankAccount.Deposit(depositAmount);
            });
        }
    }
}