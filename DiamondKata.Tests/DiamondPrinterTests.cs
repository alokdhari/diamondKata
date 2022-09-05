using FluentAssertions;

namespace DiamondKata.Tests
{
    public class DiamondPrinterTests
    {
        [Test]
        public void ShouldPrintDiamondOfOneDepth()
        {
            // Arrange
            var character = 'A';

            // Act
            var result = new DiamondPrinter().Print(character);

            // Assert
            result.Should().Be(character.ToString());
        }

        [Test]
        public void ShouldPrintFlatTextOfDepthTwoForB()
        {
            // Arrange
            var character = 'B';

            // Act
            var result = new DiamondPrinter().Print(character);

            // Assert
            result.Should().Be("ABBA");
        }
    }
}