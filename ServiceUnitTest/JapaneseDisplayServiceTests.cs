using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.Protocol;
using System;

namespace Service.UnitTest
{
    [TestClass]
    public sealed class JapaneseDisplayServiceTests
    {
        private IDisplayService service;

        [TestInitialize]
        public void TestInitialize()
        {
            this.service = new JapaneseDisplayService();
        }

        [TestMethod]
        public void GetFullNameTest_傳入Monday_預期回傳月曜日()
        {
            var dayOfWeek = DayOfWeek.Monday;

            var expected = "月曜日";

            var actual = this.service.GetFullName(dayOfWeek);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFullNameTest_傳入Friday_預期回傳金曜日()
        {
            var dayOfWeek = DayOfWeek.Friday;

            var expected = "金曜日";

            var actual = this.service.GetFullName(dayOfWeek);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetShortNameTest_傳入Wednesday_預期回傳水()
        {
            var dayOfWeek = DayOfWeek.Wednesday;

            var expected = "水";

            var actual = this.service.GetShortName(dayOfWeek);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetShortNameTest_傳入Sunday_預期回傳日()
        {
            var dayOfWeek = DayOfWeek.Sunday;

            var expected = "日";

            var actual = this.service.GetShortName(dayOfWeek);

            Assert.AreEqual(expected, actual);
        }
    }
}