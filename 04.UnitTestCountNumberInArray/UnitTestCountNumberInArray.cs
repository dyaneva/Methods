using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04.UnitTestCountNumberInArray
{
    [TestClass]
    public class UnitTestCountNumberInArray
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = {33, 4, 33, 4, 33};
            int number = 33;
            int result = CountNumberInArray.CountGivenNumberInArray(array, number);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] array = { 33, 4, 33, 4, 33, 4, 4, 4 };
            int number = 4;
            int result = CountNumberInArray.CountGivenNumberInArray(array, number);
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] array = { 33, 4, 33, 4, 33, 4, 4, 4 };
            int number = 5;
            int result = CountNumberInArray.CountGivenNumberInArray(array, number);
            Assert.AreEqual(0, result);
        }
    }
}
