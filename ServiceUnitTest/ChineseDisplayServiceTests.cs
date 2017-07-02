using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.Protocol;
using System;

namespace Service.UnitTest
{
    [TestClass]
    public sealed class ChineseDisplayServiceTests
    {
        private IDisplayService service;

        [TestInitialize]
        public void TestInitialize()
        {
            this.service = new ChineseDisplayService();
        }

        [TestMethod]
        public void GetFullNameTest_傳入Tuesday_預期回傳星期二()
        {
            var dayOfWeek = DayOfWeek.Tuesday;

            var expected = "星期二";

            var actual = this.service.GetFullName(dayOfWeek);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFullNameTest_傳入Thursday_預期回傳星期四()
        {
            var dayOfWeek = DayOfWeek.Thursday;

            var expected = "星期四";

            var actual = this.service.GetFullName(dayOfWeek);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetShortNameTest_傳入Monday_預期回傳一()
        {
            var dayOfWeek = DayOfWeek.Monday;

            var expected = "一";

            var actual = this.service.GetShortName(dayOfWeek);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetShortNameTest_傳入Saturday_預期回傳六()
        {
            var dayOfWeek = DayOfWeek.Saturday;

            var expected = "六";

            var actual = this.service.GetShortName(dayOfWeek);

            Assert.AreEqual(expected, actual);
        }
    }
}