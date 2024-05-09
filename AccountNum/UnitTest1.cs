using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankApplication;

namespace AccountNum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThatTheAccountNumbersAreFourNumbersLong()
        {
            string test = CreateBankAccount.RandomNum();

            Assert.IsTrue(test.Length == 4, "The account number must be 4 characters long!");

        }
    }
}
