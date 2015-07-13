using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3.Library;

namespace Task3.Test
{
    [TestClass]
    public class NodTest
    {
        [TestMethod]
        public void UsualDateEvklidTest()
        {
            int firstN = 585;
            int secondN = 81;
            int expected = 9;

            int nod = Nod.NodEvklid(firstN, secondN);
            Assert.AreEqual(expected, nod, "NOD not found correctly");

        }
        [TestMethod]
        public void UsualDateBinTest()
        {
            int firstN = 585;
            int secondN = 81;
            int expected = 9;

            int nod = Nod.BinaryNod(firstN, secondN);
            Assert.AreEqual(expected, nod, "NOD not found correctly");
        }
        [TestMethod]
        public void MoreArgEvklidTest()
        {
            int firstN = 585;
            int secondN = 81;
            int thirdN = 9;
            int fourth = 3;
            int more = 12;
            int expected = 3;

            int nod = Nod.NodEvklid(firstN, secondN, thirdN, fourth, more);
            Assert.AreEqual(expected, nod, "NOD not found correctly");
        }
         [TestMethod]
        public void MoreArgBinTest()
        {
            int firstN = 585;
            int secondN = 81;
            int thirdN = 9;
            int fourth = 3;
            int more = 12;
            int expected = 3;

            int nod = Nod.BinaryNod(firstN, secondN, thirdN, fourth, more);
            Assert.AreEqual(expected, nod, "NOD not found correctly");
        }
         [TestMethod]
         public void NullArgEvklidTest()
         {
             int firstN = 0;
             int secondN = 81;
             int thirdN = 9;
             int fourth = 3;
             int more = 0;
             int expected = 0;

             int nod = Nod.NodEvklid(firstN, secondN, thirdN, fourth, more);
             Assert.AreEqual(expected, nod, "NOD not found correctly");
         }
         [TestMethod]
         public void NullArgBinTest()
         {
             int firstN = 0;
             int secondN = 81;
             int thirdN = 9;
             int fourth = 3;
             int more = 0;
             int expected = 0;

             int nod = Nod.BinaryNod(firstN, secondN, thirdN, fourth, more);
             Assert.AreEqual(expected, nod, "NOD not found correctly");
         }
        [TestMethod]
         public void NegativArgEvklidTest()
         {
             int firstN = -585;
             int secondN = 81;
             int thirdN = -9;
             int fourth = 3;
             int more = 12;
             int expected = 3;

             int nod = Nod.NodEvklid(firstN, secondN, thirdN, fourth, more);
             Assert.AreEqual(expected, nod, "NOD not found correctly");
         }
        [TestMethod]
        public void NegativArgBinTest()
        {
            int firstN = -585;
            int secondN = 81;
            int thirdN = -9;
            int fourth = 3;
            int more = 12;
            int expected = 3;

            int nod = Nod.BinaryNod(firstN, secondN, thirdN, fourth, more);
            Assert.AreEqual(expected, nod, "NOD not found correctly");
        }
    }
}
