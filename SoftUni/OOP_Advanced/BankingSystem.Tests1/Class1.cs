using System;
using NUnit.Framework;
using Moq;

namespace BankingSystem.Tests1
{
    public class Class1
    {
        [TestFixture]
        public class BankAccountTests
        {
            private BankAccount bankAccount;

            public void SetUp()
            {
                this.bankAccount = new BankAccount();
            }

            [TestCase(300)]
            [TestCase(500)]
            [TestCase(0)]
            [TestCase(1500)]
            [TestCase(3500)]
            public void DepositShouldIncreaseBalance(int depositAmount)
            {
                //Arrange

                //Act
                bankAccount.Deposit(depositAmount);

                //Assert
                Assert.AreEqual(depositAmount, bankAccount.Balance);
            }

            [Test]
            public void NegativeAmountInDepositShouldThrowExeption()
            {
                //Arrange
                BankAccount bankAccount = new BankAccount();
                decimal depositAmount = 100;
                Assert.Throws<ArgumentException>(
                    () =>
                    {
                        bankAccount.Deposit(depositAmount);
                    });
            }

            [Test]
            public void NegativeAmountDeposit()
            {
                BankAccount bankAccount = new BankAccount();
                decimal depositAmount = -100;
                bankAccount.Deposit(depositAmount);

                Assert.AreEqual(-100, bankAccount.Balance);
            }
        }
    }
}
