using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENSE707_Week1_Lab;


namespace ENSE707_Week1_Lab.Tests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Deposit_PositiveAMount_IncreasesBalance()
        {
            BankAccount account = new BankAccount("Test User", 100);
            account.Deposit(50);
            Assert.AreEqual(150, account.Balance);
        }

        [TestMethod]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            BankAccount account = new BankAccount("Test User", 100);
            bool result = account.Withdraw(40);
            Assert.IsTrue(result);
            Assert.AreEqual(60, account.Balance);
        }

        [TestMethod]
        public void Withdraw_AmountGreaterThanBalance_ShouldFail()
        {
            BankAccount account = new BankAccount("Test User", 100);
            bool result = account.Withdraw(150);
            Assert.IsFalse(result);
            Assert.AreEqual(100, account.Balance);
        }
    }
}
