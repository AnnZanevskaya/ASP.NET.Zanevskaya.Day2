using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Library;

namespace RootFindingTest
{
    [TestClass]
    public class RootFindingTest
    {
        [TestMethod]
        public void NewtonRootUsualDateTest()
        {
            double number = 234.5;
            int power = 13;
            const double eps = 1e-9;
            double expected = Math.Pow(number, 1.0 / power);

            double root = RootFinding.NewtonRoot(number, power, eps);
            Assert.AreEqual(expected, root, 0.001, "Root not found correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberIsNegativeTest()
        {
            double number = -278.34;
            int power = 13;
            const double eps = 1e-9;

            RootFinding.NewtonRoot(number, power, eps);       
        }

        [TestMethod]
        public void PowerIsNegativeTest()
        {
            double number = 278.34;
            int power = -13;
            const double eps = 1e-9;
            double expected = Math.Pow(number, 1.0 / power);

            double root = RootFinding.NewtonRoot(number, power, eps);
            Assert.AreEqual(expected, root, eps, "Root not found correctly");
        }

        [TestMethod]
        public void PowerIsNull()
        {
            double number = 278.34;
            int power = 0;
            const double eps = 1e-9;
            double expected = 1;

            double root = RootFinding.NewtonRoot(number, power, eps);
            Assert.AreEqual(expected, root, eps, "Root not found correctly");
        }

    }
}
