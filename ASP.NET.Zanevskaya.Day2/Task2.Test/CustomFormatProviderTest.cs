using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Library;

namespace Task2.Test
{
    [TestClass]
    public class CustomFormatProviderTest
    {
        [TestMethod]
        public void UsualDateTest()
        {
            int number = 500;
            string expected = "1F4";

            string format = String.Format(new CustomFormatProvider(), "{0:h}", number);
            Assert.AreEqual(expected, format, "Root not found correctly");
        }
        [TestMethod]
        public void NegativeDateTest()
        {
            int number = -500;
            string expected = "fffffe0c";

            string format = String.Format(new CustomFormatProvider(), "{0:h}", number);
            format.Trim();
            Assert.AreEqual(expected, format.ToLower(), "Root not found correctly");
        }
        [TestMethod]
        public void InValidFormatTest()
        {
            string format = String.Format(new CustomFormatProvider(), "{0:G}", 15);
        }
    }
}
