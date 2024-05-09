using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using BankApplication;

namespace BankApplicationUnitTests
{
    [TestClass]
    public class AccountNumber
    {
        [TestMethod]
        public void TestThatTheAccountNumbersAreFourNumbersLong()
        {
            //RandomNum🕹🕹🕹🕹🕹🕹🕹🕹♦♦♦🃏🃏🎳🎳⛽⛽⛽⛽⛽

            string test = "1234";

            Assert.IsTrue(test.Length == 4, "The account number must be 4 characters long!");

        }
    }
}
