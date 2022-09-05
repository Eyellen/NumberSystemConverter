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
}
