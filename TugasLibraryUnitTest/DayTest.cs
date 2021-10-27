using System;
using NUnit.Framework;
using TugasLibrary;
namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class DayTest
    {
        private Day day;

        [SetUp]
        public void init()
        {
            day = new Day();
        }
        [Test]
        public void NameOfDayTest()
        {
            Assert.AreSame(day.NameOfDay(1), "Senin");
        }

    }
}
