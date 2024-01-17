using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(30, 3, 33)]
        [TestCase(16, 17, 33)]
        [TestCase(25, 8, 33)]
        [TestCase(2, 31, 33)]
        [TestCase(100, -67, 33)]
        public void SimpleAdditionOperations(int value, int valueb, int expected)
        {
            var result = MyMath.Operations.Add(value, valueb);
            Assert.AreEqual(expected, result);
        }
    }
}
