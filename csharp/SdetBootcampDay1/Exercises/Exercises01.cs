using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    [TestFixture]
    public class Exercises01
    {
        [Test]
        public void GivenANewCheckingAccount_WhenIDeposit200_ThenBalanceShouldBe200()
        {
            var account = new Account(AccountType.Checking);
            
            account.Deposit(200);

            /**
             * TODO: add an assertion that verifies that the resulting balance is 200.
             */

            Assert.That(account.Balance, Is.EqualTo(200));
               

            /**
             * TODO: add an assertion that verifies that the resulting balance is greater than 199.
             */
            account.Withdraw(1); 
            Assert.That(account.Balance, Is.EqualTo(199));
        }

        [Test]
        public void GivenANewSavingsAccount_WhenIDeposit200AndWithdraw100_ThenBalanceShouldBe100()
        {
            /**
             * TODO: create a new savings account
             */

            var account = new Account(AccountType.Savings);
            
            /**
             * TODO: first, deposit 200 dollars, then immediately withdraw 100 dollars again.
             */

            account.Deposit(200);
            account.Withdraw(100);

            
               

            /**
             * TODO: assert that the resulting balance is equal to 100.
             */
             
            Assert.That(account.Balance, Is.EqualTo(100));

        }

        [Test]
        public void GivenANewCheckingAccount_WhenIDeposit100AndWithdraw200_ThenBalanceShouldBeMinus100()
        {
            var account = new Account(AccountType.Checking);

            account.Deposit(100);
            account.Withdraw(200);

            Assert.That(account.Balance, Is.EqualTo(-100));
        }


        
        [Test]
        public void GivenANewCheckAndSavingsAccount_WhenIDeposit500CheckingAnd1000SavingsWith100BonusCash_ThenCombinedBalanceShouldBe1600()
        {
            /**
             * TODO: create a new savings account
             */

            var accountChecking = new Account(AccountType.Checking);
            var accountSaving = new Account(AccountType.Savings);
            
            /**
             * TODO: first, deposit 200 dollars, then immediately withdraw 100 dollars again.
             */

            int bonusCash = 100;
            accountChecking.Deposit(500+bonusCash);
            accountSaving.Deposit(1000);

            /**
             * TODO: assert that the resulting balance is equal to 100.
             */
             
            Assert.That(accountChecking.Balance + accountSaving.Balance, Is.EqualTo(1600));

        }
    }
}
