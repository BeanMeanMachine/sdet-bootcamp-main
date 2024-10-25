using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    [TestFixture]
    public class Exercises02
    {
        /**
         * TODO: rewrite these three tests into a single, parameterized test.
         * You decide if you want to use [TestCase] or [TestCaseSource], but
         * I would like to know why you chose the option you chose afterwards.
         */
        
        [TestCase(100, 50, 50, TestName = "Deposit 100 and withdraw 50 leaves 50")]
        [TestCase(1000, 1000, 0, TestName = "Deposit 1000 and withdraw 1000 leaves 0")]
        [TestCase(250, 1, 249, TestName = "Deposit 250 and withdraw 1 leaves 249")]   
        public void SavingAccount_DepositThenWithdraw_BlanceUpdated
           (int amountToDeposit, int amountToWithdraw, int expectedBalance)
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(amountToDeposit);
            account.Withdraw(amountToWithdraw);

            Assert.That(account.Balance, Is.EqualTo(expectedBalance));
        }

        [Test]
        public void CreateNewSavingsAccount_Deposit100Withdraw50_BalanceShouldBe50()
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(100);
            account.Withdraw(50);

            Assert.That(account.Balance, Is.EqualTo(50));
        }

        [Test]
        public void CreateNewSavingsAccount_Deposit1000Withdraw1000_BalanceShouldBe0()
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(1000);
            account.Withdraw(1000);

            Assert.That(account.Balance, Is.EqualTo(0));
        }


    }
}
