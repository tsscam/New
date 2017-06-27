using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzPuzzProject
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    Assert.Fail();
        //}
       
        
        [TestMethod]
        public void TestMethod1()
        {
            string Expected = "1";

            Assert.AreEqual(Expected, FizzBuzz.GetFizzBuzz(1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string Expected = "2";
            
            Assert.AreEqual(Expected, FizzBuzz.GetFizzBuzz(2));
        }
        [TestMethod]
        public void TestMethod3()
        {
            string Expected = "Fizz";

            Assert.AreEqual(Expected, FizzBuzz.GetFizzBuzz(3));
        }
        [TestMethod]
        public void TestMethod4()
        {
            string Expected = "4";

            Assert.AreEqual(Expected, FizzBuzz.GetFizzBuzz(4));
        }
        [TestMethod]
        public void TestMethod5()
        {
            string Expected = "Buzz";

            Assert.AreEqual(Expected, FizzBuzz.GetFizzBuzz(5));
        }
        [TestMethod]
        public void TestMethod6()
        {
            string Expected = "Fizz";

            Assert.AreEqual(Expected, FizzBuzz.GetFizzBuzz(6));
        }
        [TestMethod]
        public void TestMethod7()
        {
            string Expected = "7";

            Assert.AreEqual(Expected, FizzBuzz.GetFizzBuzz(7));
        }
        [TestMethod]
        public void TestMethod8()
        {
            string Expected = "8";

            Assert.AreEqual(Expected, FizzBuzz.GetFizzBuzz(8));
        }
        [TestMethod]
        public void TestMethod9()
        {
            string Expected = "Fizz";

            Assert.AreEqual(Expected, FizzBuzz.GetFizzBuzz(9));
        }

    }
}
