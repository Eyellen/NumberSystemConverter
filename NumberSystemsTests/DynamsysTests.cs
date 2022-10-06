using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumberSystems;

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
            byte numberSystem = 10;

            Assert.ThrowsException<NullReferenceException>(() => new Dynamsys(number, numberSystem));
        }
        [TestMethod]
        public void Dynamsys_Constructor_Test_01()
        {
            string number = string.Empty;
            byte numberSystem = 10;

            Assert.ThrowsException<Exception>(() => new Dynamsys(number, numberSystem));
        }
        [TestMethod]
        public void Dynamsys_Constructor_Test_02()
        {
            string number = "aj_)AGF-a0G";
            byte numberSystem = 10;

            Assert.ThrowsException<Exception>(() => new Dynamsys(number, numberSystem));
        }
        [TestMethod]
        public void Dynamsys_Constructor_Test_03()
        {
            string number = "AOGH.15PJ1";
            byte numberSystem = 15;


            Assert.ThrowsException<Exception>(() => new Dynamsys(number, numberSystem));
        }
        [TestMethod]
        public void Dynamsys_Constructor_Test_04()
        {
            string number = "AOGH.15PJ1";
            byte numberSystem = 26;
            bool isNegative = false;

            byte[] expectedIntegralPart = { 10, 24, 16, 17 };
            byte[] expectedFractionalPart = { 1, 5, 25, 19, 1 };

            AssertDynamsys_Constructor(number, expectedIntegralPart,
                expectedFractionalPart, numberSystem, isNegative);
        }
        [TestMethod]
        public void Dynamsys_Constructor_Test_05()
        {
            string number = "aFI97AF.9agfA";
            byte numberSystem = 19;
            bool isNegative = false;

            byte[] expectedIntegralPart = { 10, 15, 18, 9, 7, 10, 15 };
            byte[] expectedFractionalPart = { 9, 10, 16, 15, 10 };

            AssertDynamsys_Constructor(number, expectedIntegralPart,
                expectedFractionalPart, numberSystem, isNegative);
        }
        [TestMethod]
        public void Dynamsys_Constructor_Test_06()
        {
            string number = "-aFI97AF.9agfA";
            byte numberSystem = 19;
            bool isNegative = true;

            byte[] expectedIntegralPart = { 10, 15, 18, 9, 7, 10, 15 };
            byte[] expectedFractionalPart = { 9, 10, 16, 15, 10 };

            AssertDynamsys_Constructor(number, expectedIntegralPart,
                expectedFractionalPart, numberSystem, isNegative);
        }
        [TestMethod]
        public void Dynamsys_Constructor_Test_07()
        {
            string number = "+aFI97AF.9agfA";
            byte numberSystem = 19;
            bool isNegative = false;

            byte[] expectedIntegralPart = { 10, 15, 18, 9, 7, 10, 15 };
            byte[] expectedFractionalPart = { 9, 10, 16, 15, 10 };

            AssertDynamsys_Constructor(number, expectedIntegralPart,
                expectedFractionalPart, numberSystem, isNegative);
        }
        [TestMethod]
        public void Dynamsys_Constructor_Test_08()
        {
            string number = "aFI97AF";
            byte numberSystem = 19;
            bool isNegative = false;

            byte[] expectedIntegralPart = { 10, 15, 18, 9, 7, 10, 15 };
            byte[] expectedFractionalPart = Array.Empty<byte>();

            AssertDynamsys_Constructor(number, expectedIntegralPart,
                expectedFractionalPart, numberSystem, isNegative);
        }
        [TestMethod]
        public void Dynamsys_Constructor_Test_09()
        {
            string number = ".9agfA";
            byte numberSystem = 19;
            bool isNegative = false;

            byte[] expectedIntegralPart = Array.Empty<byte>();
            byte[] expectedFractionalPart = { 9, 10, 16, 15, 10 };

            AssertDynamsys_Constructor(number, expectedIntegralPart,
                expectedFractionalPart, numberSystem, isNegative);
        }

        private void AssertDynamsys_Constructor(string number, byte[] expectedIntegralPart,
            byte[] expectedFractionalPart, byte numberSystem, bool isNegative)
        {
            Dynamsys dynamsys = new Dynamsys(number, numberSystem);

            PrivateObject privateDynamsys = new PrivateObject(dynamsys);
            byte actualNumberSystem = (byte)privateDynamsys.GetField("_currentNumberSystem");
            bool actualIsNegative = (bool)privateDynamsys.GetField("_isNegative");
            byte[] actualIntegralPart = (byte[])privateDynamsys.GetField("_integralPart");
            byte[] actualFractionalPart = (byte[])privateDynamsys.GetField("_fractionalPart");

            // Output
            Console.WriteLine("Actual number system: " + actualNumberSystem);
            Console.WriteLine("Actual is negative: " + actualIsNegative);

            Console.Write("Actual integral part:\t");
            foreach (var item in actualIntegralPart)
                Console.Write($" {item}");
            Console.WriteLine();

            Console.Write("Actual fractional part:\t");
            foreach (var item in actualFractionalPart)
                Console.Write($" {item}");
            Console.WriteLine();
            //

            Assert.AreEqual(numberSystem, actualNumberSystem);
            Assert.AreEqual(isNegative, actualIsNegative);
            CollectionAssert.AreEqual(expectedIntegralPart, actualIntegralPart);
            CollectionAssert.AreEqual(expectedFractionalPart, actualFractionalPart);
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

        #region RemoveExtraFrontZeros Method Tests
        [TestMethod]
        public void RemoveExtraFrontZeros_Test_00()
        {
            string number = "000000";
            string expectedResult = string.Empty;

            Assert.AreEqual(expectedResult, Dynamsys.RemoveExtraFrontZeros(number));
        }
        [TestMethod]
        public void RemoveExtraFrontZeros_Test_01()
        {
            string number = "000014515";
            string expectedResult = "14515";

            Assert.AreEqual(expectedResult, Dynamsys.RemoveExtraFrontZeros(number));
        }
        [TestMethod]
        public void RemoveExtraFrontZeros_Test_02()
        {
            string number = "00001451500000";
            string expectedResult = "1451500000";

            Assert.AreEqual(expectedResult, Dynamsys.RemoveExtraFrontZeros(number));
        }
        #endregion

        #region RemoveExtraRearZeros Method Tests
        [TestMethod]
        public void RemoveExtraRearZeros_Test_00()
        {
            string number = "000000";
            string expectedResult = string.Empty;

            Assert.AreEqual(expectedResult, Dynamsys.RemoveExtraRearZeros(number));
        }
        [TestMethod]
        public void RemoveExtraRearZeros_Test_01()
        {
            string number = "000014515";
            string expectedResult = "000014515";

            Assert.AreEqual(expectedResult, Dynamsys.RemoveExtraRearZeros(number));
        }
        [TestMethod]
        public void RemoveExtraRearZeros_Test_02()
        {
            string number = "00001451500000";
            string expectedResult = "000014515";

            Assert.AreEqual(expectedResult, Dynamsys.RemoveExtraRearZeros(number));
        }
        #endregion

        #region ToArray Method Tests
        [TestMethod]
        public void ToArray_Test_00()
        {
            string number = null;

            Assert.ThrowsException<NullReferenceException>(() => Dynamsys.ToArray(number));
        }
        [TestMethod]
        public void ToArray_Test_01()
        {
            string number = string.Empty;

            Assert.ThrowsException<Exception>(() => Dynamsys.ToArray(number));
        }
        [TestMethod]
        public void ToArray_Test_02()
        {
            string number = "AOHO913";
            byte[] expectedResult = { 10, 24, 17, 24, 9, 1, 3 };

            CollectionAssert.AreEqual(expectedResult, Dynamsys.ToArray(number));
        }
        [TestMethod]
        public void ToArray_Test_03()
        {
            string number = "oahf09ah3";
            byte[] expectedResult = { 24, 10, 17, 15, 0, 9, 10, 17, 3 };

            CollectionAssert.AreEqual(expectedResult, Dynamsys.ToArray(number));
        }
        #endregion

        #region ToString Method Tests
        [TestMethod]
        public void ToString_Test_00()
        {
            Dynamsys dynamsys = new Dynamsys("14.5163", 10);
            string expectedResult = "14.5163";

            Assert.AreEqual(expectedResult, dynamsys.ToString());
        }
        [TestMethod]
        public void ToString_Test_01()
        {
            Dynamsys dynamsys = new Dynamsys("A8F43.7B8CD", 16);
            string expectedResult = "A8F43.7B8CD";

            Assert.AreEqual(expectedResult, dynamsys.ToString());
        }
        [TestMethod]
        public void ToString_Test_02()
        {
            Dynamsys dynamsys = new Dynamsys("-A8F43.7B8CD", 16);
            string expectedResult = "-A8F43.7B8CD";

            Assert.AreEqual(expectedResult, dynamsys.ToString());
        }
        [TestMethod]
        public void ToString_Test_03()
        {
            Dynamsys dynamsys = new Dynamsys(".7B8CD", 16);
            string expectedResult = "0.7B8CD";

            Assert.AreEqual(expectedResult, dynamsys.ToString());
        }
        #endregion

        #region Equals Method Tests
        [TestMethod]
        public void Equals_Test_00()
        {
            Dynamsys a = new Dynamsys("15136.1215", 10);
            Dynamsys b = new Dynamsys("15136.1215", 10);
            bool areEqual = true;

            Assert.AreEqual(areEqual, a.Equals(b));
            Assert.AreEqual(areEqual, Dynamsys.Equals(a, b));
        }
        [TestMethod]
        public void Equals_Test_01()
        {
            Dynamsys a = new Dynamsys("15136.1215", 10);
            Dynamsys b = new Dynamsys("15136", 10);
            bool areEqual = false;

            Assert.AreEqual(areEqual, a.Equals(b));
            Assert.AreEqual(areEqual, Dynamsys.Equals(a, b));
        }
        [TestMethod]
        public void Equals_Test_02()
        {
            Dynamsys a = new Dynamsys("15136.1215", 10);
            Dynamsys b = new Dynamsys("-15136.1215", 10);
            bool areEqual = false;

            Assert.AreEqual(areEqual, a.Equals(b));
            Assert.AreEqual(areEqual, Dynamsys.Equals(a, b));
        }
        [TestMethod]
        public void Equals_Test_03()
        {
            Dynamsys a = new Dynamsys("15136.1215", 10);
            Dynamsys b = new Dynamsys("15136.1215", 12);
            bool areEqual = false;

            Assert.AreEqual(areEqual, a.Equals(b));
            Assert.AreEqual(areEqual, Dynamsys.Equals(a, b));
        }
        [TestMethod]
        public void Equals_Test_04()
        {
            Dynamsys a = new Dynamsys(".1215", 10);
            Dynamsys b = new Dynamsys(".1215", 10);
            bool areEqual = true;

            Assert.AreEqual(areEqual, a.Equals(b));
            Assert.AreEqual(areEqual, Dynamsys.Equals(a, b));
        }
        [TestMethod]
        public void Equals_Test_05()
        {
            Dynamsys a = null;
            Dynamsys b = new Dynamsys(".1215", 10);

            Assert.ThrowsException<NullReferenceException>(() => a.Equals(b));
            Assert.ThrowsException<NullReferenceException>(() => Dynamsys.Equals(a, b));
        }
        #endregion
    }
}
