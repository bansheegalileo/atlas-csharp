using NUnit.Framework;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
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
        public void TestCase1(){
            int[,] test = new int[,] { { 3, 3 }, { 7, 9 }, { 10, 11 }, { 13, 40 } };
            Assert.IsNull(MyMath.Matrix.Divide(test, 0));
        }
        [Test]
        public void TestCase2(){
            int[,] test = new int[,] { { 44, 4 }, { 10, 8 }, { 480, 44 }, { 26, 40 } };
            Assert.AreEqual(new int[,] {{22, 2}, {5, 4}, {240, 22}, {13, 20}}, MyMath.Matrix.Divide(test, 2));
        }
        [Test]
        public void TestCase3(){
            Assert.IsNull(MyMath.Matrix.Divide(null, 2));
        }
    }
}
