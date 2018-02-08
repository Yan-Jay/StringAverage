using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringAverage;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOneCorrect()
        {
            var test = new ClassAverageString();
            var input = "one";
            var actual =  test.convert(input);
            var expect = "one";
            Assert.AreEqual(expect,actual);

        }

        [TestMethod]
        public void TestTwoFourCorrect()
        {
            var test = new ClassAverageString();
            var input = "two four";
            var actual = test.convert(input);
            var expect = "three";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestOneTwoFourSixCorrect()
        {
            var test = new ClassAverageString();
            var input = "two four six";
            var actual = test.convert(input);
            var expect = "four";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestTwoCatNa()
        {
            var test = new ClassAverageString();
            var input = "two cat";
            var actual = test.convert(input);
            var expect = "n/a";
            Assert.AreEqual(expect, actual);
        }
    }
}
