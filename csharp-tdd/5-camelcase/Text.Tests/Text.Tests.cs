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
            Assert.AreEqual(0, Text.Str.CamelCase(null));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, Text.Str.CamelCase("Howdy"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(2, Text.Str.CamelCase("Howdy Doody"));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(3, Text.Str.CamelCase("Howdy there Old Chum"));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(1, Text.Str.CamelCase("Howdy"));
        }
        [Test]
        public void Test5(){
            Assert.AreEqual(0, Text.Str.CamelCase("666"));
        }
        [Test]
        public void Test6(){
            Assert.AreEqual(1, Text.Str.CamelCase("666 Woomy"));
        }
        [Test]
        public void Test7(){
            Assert.AreEqual(0, Text.Str.CamelCase("666 666"));
        }
        [Test]
        public void Test8(){
            Assert.AreEqual(0, Text.Str.CamelCase(""));
        }
        [Test]
        public void Test9(){
            Assert.AreEqual(0, Text.Str.CamelCase("he he he he he he he"));
        }
        [Test]
        public void Test10(){
            Assert.AreEqual(7, Text.Str.CamelCase("This Is A Test Sentence, Ya Dig?"));
        }
        [Test]
        public void Test11(){
            Assert.AreEqual(3, Text.Str.CamelCase(" ToaST"));
        }
        [Test]
        public void Test12(){
            Assert.AreEqual(1, Text.Str.CamelCase("          Toast"));
        }
        [Test]
        public void Test13(){
            Assert.AreEqual(3, Text.Str.CamelCase("Woah it's Hatsune Miku"));
        }
        [Test]
        public void Test14(){
            Assert.AreEqual(6, Text.Str.CamelCase("ThisIsACamelCaseString"));
        }
    }
}
