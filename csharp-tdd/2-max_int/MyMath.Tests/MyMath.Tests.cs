using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(0, MyMath.Operations.Max(new List<int>()));
        }
        [Test]
        public void Test2()
        {
            List<int> myList = new List<int>() { 3, 7, 9, 11, 53 };
            Assert.AreEqual(53, MyMath.Operations.Max(myList));
        }
        [Test]
        public void Test3()
        {
            List<int> myList = new List<int>() { -53, -11, -3 };
            Assert.AreEqual(-3, MyMath.Operations.Max(myList));
        }
        [Test]
        public void Test4()
        {
            List<int> myList = new List<int>() { 7 };
            Assert.AreEqual(7, MyMath.Operations.Max(myList));
        }
        [Test]
        public void Test5()
        {
            List<int> myList = new List<int>() { -7, 0 };
            Assert.AreEqual(0, MyMath.Operations.Max(myList));
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(0, MyMath.Operations.Max(null));
        }
    }
}
