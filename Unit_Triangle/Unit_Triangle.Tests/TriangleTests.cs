using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Triangle;

namespace Unit_Triangle.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void inequality_3and4and5_true()
        {
            //arrange
            int a = -3;
            int b = 4;
            int c = 5;
            bool expected = true;

            //act
            Triangle triangle = new Triangle();
            bool actual = triangle.inequality(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void inequality_5and5and5_NotNull()
        {
            //arrange
            int a = 5;
            int b = 5;
            int c = 5;

            //act
            Triangle triangle = new Triangle();
            bool result = triangle.inequality(a, b, c);

            //assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void inequality_54and80and10_false()
        {
            //arrange
            int a = 54;
            int b = 80;
            int c = 10;
            bool expected = false;

            //act
            Triangle triangle = new Triangle();
            bool actual = triangle.inequality(a, b, c);

            //assert
            Assert.AreNotSame(expected, actual);
        }

        [TestMethod]
        public void inequality_minus87and90and100_false()
        {
            //arrange
            int a = -87;
            int b = 90;
            int c = 100;
            bool expected = false;

            //act
            Triangle triangle = new Triangle();
            bool actual = triangle.inequality(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void inequality_10and20and30_isFalse()
        {
            //arrange
            int a = 10;
            int b = 20;
            int c = 30;

            //act
            Triangle triangle = new Triangle();
            bool result = triangle.inequality(a, b, c);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void inequality_150and222and123_isTrue()
        {
            //arrange
            int a = 150;
            int b = 222;
            int c = 123;

            //act
            Triangle triangle = new Triangle();
            bool result = triangle.inequality(a, b, c);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void inequality_1276and98and5_false()
        {
            //arrange
            int a = 1276;
            int b = 98;
            int c = 5;
            bool expected = false;

            //act
            Triangle triangle = new Triangle();
            bool actual = triangle.inequality(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void inequality_3and3and3_isTrue()
        {
            //arrange
            int a = 3;
            int b = 3;
            int c = 3;

            //act
            Triangle triangle = new Triangle();
            bool result = triangle.inequality(a, b, c);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void inequality_0and6and8_isFalse()
        {
            //arrange
            int a = 0;
            int b = 6;
            int c = 8;

            //act
            Triangle triangle = new Triangle();
            bool result = triangle.inequality(a, b, c);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void inequality_15and20and17_true()
        {
            //arrange
            int a = 15;
            int b = 20;
            int c = 17;
            bool expected = true;

            //act
            Triangle triangle = new Triangle();
            bool actual = triangle.inequality(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
