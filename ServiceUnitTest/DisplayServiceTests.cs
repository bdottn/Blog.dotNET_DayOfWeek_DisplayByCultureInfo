using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Service.UnitTest
{
    [TestClass]
    public sealed class DisplayServiceTests
    {
        private DisplayService service;

        [TestInitialize]
        public void TestInitialize()
        {
            this.service = new DisplayService();
        }

        [TestMethod]
        public void GetFullNameTest_傳入Sunday_預期回傳星期日()
        {
            var dayOfWeek = DayOfWeek.Sunday;

            var expected = "星期日";

            var actual = this.service.GetFullName(dayOfWeek);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFullNameTest_傳入Friday_預期回傳星期五()
        {
            var dayOfWeek = DayOfWeek.Friday;

            var expected = "星期五";

            var actual = this.service.GetFullName(dayOfWeek);

            Assert.AreEqual(expected, actual);
        }
    }
}