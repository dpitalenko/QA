using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Triangle;

namespace Unit_Triangle.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void IsTrianglePossible_3and4and5_IsTrue() => Assert.IsTrue(new Triangle().IsTrianglePossible(3, 4, 5));

        [TestMethod]
        public void IsTrianglePossible_5and5and5_NotNull() => Assert.IsNotNull(new Triangle().IsTrianglePossible(5, 5, 5));

        [TestMethod]
        public void IsTrianglePossible_54and80and10_false() => Assert.AreNotSame(false, new Triangle().IsTrianglePossible(54, 80, 10));

        [TestMethod]
        public void IsTrianglePossible_minus87and90and100_IsFalse() => Assert.IsFalse(new Triangle().IsTrianglePossible(-87, 90, 100));

        [TestMethod]
        public void IsTrianglePossible_10and20and30_IsFalse() => Assert.IsFalse(new Triangle().IsTrianglePossible(10, 20, 30));

        [TestMethod]
        public void IsTrianglePossible_150and222and123_IsTrue() => Assert.IsTrue(new Triangle().IsTrianglePossible(150, 222, 123));

        [TestMethod]
        public void IsTrianglePossible_1276and98and5_IsFalse() => Assert.IsFalse(new Triangle().IsTrianglePossible(1276, 98, 5));

        [TestMethod]
        public void IsTrianglePossible_3and3and3_IsTrue() => Assert.IsTrue(new Triangle().IsTrianglePossible(3, 3, 3));

        [TestMethod]
        public void IsTrianglePossible_0and6and8_IsFalse() => Assert.IsFalse(new Triangle().IsTrianglePossible(0, 6, 8));

        [TestMethod]
        public void IsTrianglePossible_15and20and17_IsTrue() => Assert.IsTrue(new Triangle().IsTrianglePossible(15, 20, 17));
    }
}
