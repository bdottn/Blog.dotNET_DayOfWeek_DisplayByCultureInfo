using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.Protocol;
using System;

namespace Service.UnitTest
{
    [TestClass]
    public sealed class DisplayServiceTests
    {
        private IDisplayService service;

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

        [TestMethod]
        public void GetShortNameTest_傳入Wednesday_預期回傳三()
        {
            var dayOfWeek = DayOfWeek.Wednesday;

            var expected = "三";

            var actual = this.service.GetShortName(dayOfWeek);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetShortNameTest_傳入Thursday_預期回傳四()
        {
            var dayOfWeek = DayOfWeek.Thursday;

            var expected = "四";

            var actual = this.service.GetShortName(dayOfWeek);

            Assert.AreEqual(expected, actual);
        }
    }
}