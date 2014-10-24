using System;
using EksamenProve;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccountTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOwnerSuccessfull()
        {
            var account = new BankAccount("Martin");

            try
            {
                Assert.AreEqual("Martin", account.CheckOwner());
            }
            catch (Exception)
            {
                Assert.Fail("Exception should not have happened");
            }
            
        }

        [TestMethod]
        public void TestEmptyOwner()
        {
            var account = new BankAccount("");

            try
            {
                account.CheckOwner();
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Owner cannot be null or empty", e.Message);
            }
        }


        [TestMethod]
        public void TestSuccessfullInterestRate()
        {
            var account = new BankAccount("Martin", 1);

            try
            {
                Assert.AreEqual(1, account.CheckInterestRate());
            }
            catch (Exception)
            {
                Assert.Fail("Exception should not have happened");
            }
        }

        [TestMethod]
        public void TestZeroInterestRate()
        {
            var account = new BankAccount("Martin", 0);
            try
            {
                Assert.AreEqual(0, account.CheckInterestRate());
            }
            catch (Exception)
            {
                Assert.Fail("Exception should not have happened");
            }
        }

        [TestMethod]
        public void TestNegativeInterestRate()
        {
            var account = new BankAccount("Martin", -0.1);

            try
            {
                account.CheckInterestRate();
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Interest Rate cannot be less than zero", e.Message);
            }
        }
    }
}
