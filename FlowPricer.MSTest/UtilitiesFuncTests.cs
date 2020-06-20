using System;
using FlowPricer.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace FlowPricer.MSTest
{
    [TestClass]
    public class UtilitiesFuncTests
    {
        [TestMethod]
        public void ConvertSwapToZero_ZeroValues_ReturnZeros()
        {
            //Arrange
            var utilityObj = new RatesSpreadsUtility();

            //Act
            double[] input = new double[] { 0, 0, 0, 0 };
            double[] target = new double[] { 0, 0, 0, 0 };
            var result = utilityObj.ConvertSwapRatesToZero(input);

            //Assert
            string msg = "Test array is not the same as expected array! Please re-write/run unit test.";
            Microsoft.VisualStudio.TestTools.UnitTesting.CollectionAssert.AreEqual(target, result, msg); //Assert.AreEqual(result[0], target[0]);
        }
    }

    [TestFixture]
    public class RatesTest
    {
        [Test]
        public void ConvertSwapToZero_ZeroValues_ReturnZero()
        {
            //Arrange
            var utilityObj = new RatesSpreadsUtility();

            //Act
            double[] input = new double[] { 0, 0, 0, 0 };
            double[] target = new double[] { 0, 0, 0, 0 };
            var result = utilityObj.ConvertSwapRatesToZero(input);

            //Assert
            string msg = "Test array is not the same as expected array! Please re-write/run unit test.";
            NUnit.Framework.CollectionAssert.AreEqual(target, result, msg); //Assert.AreEqual(result[0], target[0]);
        }

    }

}
