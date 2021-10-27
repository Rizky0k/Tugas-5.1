using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TugasLibrary;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class UserTest
    {
        private User user;

        [SetUp]
        public void init()
        {
            user = new User();
        }
        [Test]
        public void TestUserValid()
        {
            Assert.IsTrue(user.IsValidUser("admin","admin"));
        }
    }
}
