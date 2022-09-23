using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryNumberSystems;

namespace NumberSystemsTests
{
    [TestClass]
    public class NumberSystemsTests
    {
        [TestMethod]
        public void NumberSystem_ToDecimalSystem_Test1()
        {
            string numberToTranslate = "A42F"; // 16 number system
            string expectedResult = "42031"; // 10 number system

            string actualResult = NumberSystems.ToDecimalSystem(numberToTranslate, fromSystem: 16);

            Assert.AreEqual(expectedResult, actualResult, ignoreCase: true);
        }
        [TestMethod]
        public void NumberSystem_ToDecimalSystem_Test2()
        {
            string numberToTranslate = "13221"; // 4 number system
            string expectedResult = "489"; // 10 number system

            string actualResult = NumberSystems.ToDecimalSystem(numberToTranslate, fromSystem: 4);

            Assert.AreEqual(expectedResult, actualResult, ignoreCase: true);
        }
        [TestMethod]
        public void NumberSystem_ToDecimalSystem_Test3()
        {
            string numberToTranslate = "17,435"; // 8 number system
            double expectedResult = 15.556640625; // 10 number system

            double actualResult;
            double.TryParse(NumberSystems.ToDecimalSystem(numberToTranslate, fromSystem: 8), out actualResult);

            Assert.AreEqual(expectedResult, actualResult, 1e-7);
        }
        [TestMethod]
        public void NumberSystem_ToCustomSystem_Test1()
        {
            string numberToTranslate = "743"; // 10 number system
            string expectedResult = "23213"; // 4 number system

            string actualResult = NumberSystems.ToCustomSystem(numberToTranslate, toSystem: 4);

            Assert.AreEqual(expectedResult, actualResult, ignoreCase: true);
        }
        [TestMethod]
        public void NumberSystem_ToCustomSystem_Test2()
        {
            string numberToTranslate = "13221"; // 10 number system
            string expectedResult = "33A5"; // 16 number system

            string actualResult = NumberSystems.ToCustomSystem(numberToTranslate, toSystem: 16);

            Assert.AreEqual(expectedResult, actualResult, ignoreCase: true);
        }
        [TestMethod]
        public void NumberSystem_ToCustomSystem_Test3()
        {
            string numberToTranslate = "17,435"; // 10 number system
            double expectedResult = 21.33656050753; // 8 number system

            double actualResult;
            double.TryParse(NumberSystems.ToCustomSystem(numberToTranslate, toSystem: 8), out actualResult);

            Assert.AreEqual(expectedResult, actualResult, 1e-7);
        }
    }

    [TestClass]
    public class DynamsysTests
    {
        #region Dynamsys Constructor Tests
        [TestMethod]
        public void Dynamsys_Constructor_Test_01()
        {

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
        #endregion

        #region SizeOfIntegralPart Method Tests
        [TestMethod]
        public void SizeOfIntegralPart_Test_00()
        {
            string number = "aofh)(*f0ah";

            Assert.ThrowsException<Exception>(() => Dynamsys.SizeOfIntegralPart(number));
        }
        [TestMethod]
        public void SizeOfIntegralPart_Test_01()
        {
            string number = "ABF14.fA54r";
            int size = 5;

            Assert.AreEqual(size, Dynamsys.SizeOfIntegralPart(number));
        }
        [TestMethod]
        public void SizeOfIntegralPart_Test_02()
        {
            string number = ".8afG";
            int size = 0;

            Assert.AreEqual(size, Dynamsys.SizeOfIntegralPart(number));
        }
        [TestMethod]
        public void SizeOfIntegralPart_Test_03()
        {
            string number = "8afG";
            int size = 4;

            Assert.AreEqual(size, Dynamsys.SizeOfIntegralPart(number));
        }
        [TestMethod]
        public void SizeOfIntegralPart_Test_04()
        {
            string number = "+8afG";
            int size = 4;

            Assert.AreEqual(size, Dynamsys.SizeOfIntegralPart(number));
        }
        [TestMethod]
        public void SizeOfIntegralPart_Test_05()
        {
            string number = "+.8afG";
            int size = 0;

            Assert.AreEqual(size, Dynamsys.SizeOfIntegralPart(number));
        }
        #endregion

        #region SizeOfFractionalPart Method Tests
        [TestMethod]
        public void SizeOfFractionalPart_Test_00()
        {
            string number = "oia-9fgu(";

            Assert.ThrowsException<Exception>(() => Dynamsys.SizeOfFractionalPart(number));
        }
        [TestMethod]
        public void SizeOfFractionalPart_Test_01()
        {
            string number = "ABF14.fA54r";
            int size = 5;

            Assert.AreEqual(size, Dynamsys.SizeOfFractionalPart(number));
        }
        [TestMethod]
        public void SizeOfFractionalPart_Test_02()
        {
            string number = "ABF14.";
            int size = 0;

            Assert.AreEqual(size, Dynamsys.SizeOfFractionalPart(number));
        }
        [TestMethod]
        public void SizeOfFractionalPart_Test_03()
        {
            string number = "ABF14";
            int size = 0;

            Assert.AreEqual(size, Dynamsys.SizeOfFractionalPart(number));
        }
        [TestMethod]
        public void SizeOfFractionalPart_Test_04()
        {
            string number = "+ABF14";
            int size = 0;

            Assert.AreEqual(size, Dynamsys.SizeOfFractionalPart(number));
        }
        [TestMethod]
        public void SizeOfFractionalPart_Test_05()
        {
            string number = "+.ABF14";
            int size = 5;

            Assert.AreEqual(size, Dynamsys.SizeOfFractionalPart(number));
        }
        #endregion
    }
}
