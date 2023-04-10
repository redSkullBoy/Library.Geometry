namespace Library.Geometry.Tests
{
    public class FigureTests
    {
        [Fact]
        public void CircleAreaTest()
        {
            // Arrange
            double radius = 3;
            double expectedArea = Math.PI * radius * radius;
            var circle = new Circle(radius);

            // Act
            double actualArea = circle.GetArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double s = (side1 + side2 + side3) / 2;
            double expectedArea = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            var triangle = new Triangle(side1, side2, side3);

            // Act
            double actualArea = triangle.GetArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void IsRightTriangleTest()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            var triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRightTriangle);
        }
    }
}