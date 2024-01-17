using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestNull()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar(null));
        }
        [Test]
        public void TestFirstLetter()
        {
            Assert.AreEqual(0, Text.Str.UniqueChar("howdy"));
        }
        [Test]
        public void TestNotSameInTheLast()
        {
            Assert.AreEqual(6, Text.Str.UniqueChar("mmmeeepzoob"));
        }
        [Test]
        public void TestThirdLetter()
        {
            Assert.AreEqual(2, Text.Str.UniqueChar("mmep"));
        }
        [Test]
        public void TestLastLetter()
        {
            Assert.AreEqual(8, Text.Str.UniqueChar("eeeeeeeep"));
        }
        [Test]
        public void TestAllSame()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar("aaaaaaaaaa"));
        }
    }
}
