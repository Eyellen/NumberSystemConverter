using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryNumberSystems;

namespace NumberSystemsTests
{
    [TestClass]
    public class DynamsysTests
    {
        #region Dynamsys Constructor Tests
        [TestMethod]
        public void Dynamsys_Constructor_Test_00()
        {
            string number = null;

            Assert.ThrowsException<NullReferenceException>(() => new Dynamsys(number));
        }
        [TestMethod]
        public void Dynamsys_Constructor_Test_01()
        {
            string number = string.Empty;

            Assert.ThrowsException<Exception>(() => new Dynamsys(number));
        }
        [TestMethod]
        public void Dynamsys_Constructor_Test_02()
        {
            string number = "aj_)AGF-a0G";

            Assert.ThrowsException<Exception>(() => new Dynamsys(number));
        }
        #endregion

        #region IsNumber Method Tests
        [TestMethod]
        public void IsNumber_Test00()
        {
            string number = null;

            Assert.ThrowsException<NullReferenceException>(() => Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test01()
        {
            string number = "1009";
            bool isNumber = true;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test02()
        {
            string number = "AbcXyz";
            bool isNumber = true;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test03()
        {
            string number = "-";
            bool isNumber = false;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test04()
        {
            string number = ".";
            bool isNumber = false;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test05()
        {
            string number = "+.";
            bool isNumber = false;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test06()
        {
            string number = "-/=+";
            bool isNumber = false;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test07()
        {
            string number = "-/abd=+af";
            bool isNumber = false;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test08()
        {
            string number = "10.132";
            bool isNumber = true;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test09()
        {
            string number = "-A.534";
            bool isNumber = true;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test10()
        {
            string number = "+0.F3bc";
            bool isNumber = true;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test11()
        {
            string number = string.Empty;

            Assert.ThrowsException<Exception>(() => Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test12()
        {
            string number = "oia-9fgu(";
            bool isNumber = false;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test13()
        {
            string number = "*()$#@^%";
            bool isNumber = false;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test14()
        {
            string number = "*()a$#@^%";
            bool isNumber = false;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        [TestMethod]
        public void IsNumber_Test15()
        {
            string number = "A()$#@^%fd";
            bool isNumber = false;

            Assert.IsTrue(isNumber == Dynamsys.IsNumber(number));
        }
        #endregion

        #region GetIntegralPart Method Tests
        [TestMethod]
        public void GetIntegralPart_Test_00()
        {
            string number = null;

            Assert.ThrowsException<NullReferenceException>(() => Dynamsys.GetIntegralPart(number));
        }
        [TestMethod]
        public void GetIntegralPart_Test_01()
        {
            string number = string.Empty;

            Assert.ThrowsException<Exception>(() => Dynamsys.GetIntegralPart(number));
        }
        [TestMethod]
        public void GetIntegralPart_Test_02()
        {
            string number = "AFG53I.AO1H5109L1K";
            string expectedResult = "AFG53I";

            Assert.AreEqual(expectedResult, Dynamsys.GetIntegralPart(number));
        }
        [TestMethod]
        public void GetIntegralPart_Test_03()
        {
            string number = "+15OHB.141";
            string expectedResult = "15OHB";

            Assert.AreEqual(expectedResult, Dynamsys.GetIntegralPart(number));
        }
        [TestMethod]
        public void GetIntegralPart_Test_04()
        {
            string number = "PIAGPIHN";
            string expectedResult = "PIAGPIHN";

            Assert.AreEqual(expectedResult, Dynamsys.GetIntegralPart(number));
        }
        [TestMethod]
        public void GetIntegralPart_Test_05()
        {
            string number = ".9UQG";
            string expectedResult = string.Empty;

            Assert.AreEqual(expectedResult, Dynamsys.GetIntegralPart(number));
        }
        #endregion

        #region GetFractionalPart Method Tests
        [TestMethod]
        public void GetFractionalPart_Test_00()
        {
            string number = null;

            Assert.ThrowsException<NullReferenceException>(() => Dynamsys.GetFractionalPart(number));
        }
        [TestMethod]
        public void GetFractionalPart_Test_01()
        {
            string number = string.Empty;

            Assert.ThrowsException<Exception>(() => Dynamsys.GetFractionalPart(number));
        }
        [TestMethod]
        public void GetFractionalPart_Test_02()
        {
            string number = "API.151GH0QIN";
            string expectedResult = "151GH0QIN";

            Assert.AreEqual(expectedResult, Dynamsys.GetFractionalPart(number));
        }
        [TestMethod]
        public void GetFractionalPart_Test_03()
        {
            string number = "09A7GA";
            string expectedResult = string.Empty;

            Assert.AreEqual(expectedResult, Dynamsys.GetFractionalPart(number));
        }
        [TestMethod]
        public void GetFractionalPart_Test_04()
        {
            string number = ".09A7GA";
            string expectedResult = "09A7GA";

            Assert.AreEqual(expectedResult, Dynamsys.GetFractionalPart(number));
        }
        [TestMethod]
        public void GetFractionalPart_Test_05()
        {
            string number = "+.09A7GA";
            string expectedResult = "09A7GA";

            Assert.AreEqual(expectedResult, Dynamsys.GetFractionalPart(number));
        }
        #endregion
    }
}
