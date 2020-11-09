using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using SWE1_MTCG;
using SWE1_MTCG.Card;
using SWE1_MTCG.User;

namespace SWE1_MTCG.Test
{
    class UserTests
    {
        [Test]
        public void TestAddCoins()
        {
            MTCGUser user1 = new MTCGUser("Tester", 1, 20);
            user1.addCoins(5);
            Assert.AreEqual(user1.Coinbalance, 25);
        }

        [Test]
        public void TestRemoveCoins()
        {
            MTCGUser user1 = new MTCGUser("Tester", 1, 20);
            user1.removeCoins(5);
            Assert.AreEqual(user1.Coinbalance, 15);
            user1.removeCoins(30);
            Assert.AreEqual(user1.Coinbalance, 0);
        }

    }
}
