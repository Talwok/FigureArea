using NUnit.Framework;

namespace FigureArea.Tests
{
    public class Tests
    {
        private Shape shape;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleAreaValueTest()
        {
            shape = new Circle(20);
            var resultArea = shape.GetArea();
            Assert.IsTrue(resultArea == 125.664);
        }
        [Test]
        public void CircleAreaEmptyTest()
        {
            shape = new Circle();
            var resultArea = shape.GetArea();
            Assert.IsTrue(resultArea == 0);
        }
        [Test]
        public void TriangleAreaValueTest()
        {
            shape = new Triangle(new System.Drawing.Point(10,5), new System.Drawing.Point(2, 7), new System.Drawing.Point(5, 6));
            var resultArea = shape.GetArea();
            Assert.IsTrue(resultArea == 1);
        }
        [Test]
        public void TriangleAreaEmptyTest()
        {
            shape = new Triangle();
            var resultArea = shape.GetArea();
            Assert.IsTrue(resultArea == 0);
        }
        [Test]
        public void IsASquareTriangleTest()
        {
            shape = new Triangle(new System.Drawing.Point(10, 5), new System.Drawing.Point(2, 7), new System.Drawing.Point(5, 6));
            Assert.IsFalse((shape as Triangle).IsASquareTriangle());
        }
    }
}