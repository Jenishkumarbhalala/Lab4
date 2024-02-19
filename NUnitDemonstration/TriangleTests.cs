using NUnit.Framework;

namespace NUnitDemonstration
{
    public class TriangleTests
    {
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 90;
            int secondAngle = 45;
            int thirdAngle = 45;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_Equilateral_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void ValidTriangle_InvalidSum_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 90;
            int secondAngle = 60;
            int thirdAngle = 30;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
    }
}