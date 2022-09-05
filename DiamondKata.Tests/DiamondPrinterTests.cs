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
        public void ShouldPrintFlatTextOfDepthTwoForBAsDiamond()
        {
            // Arrange
            var character = 'B';

            // Act
            var result = new DiamondPrinter().Print(character);

            var expectedDiamond = File.ReadAllText(@"./TestFiles/diamondB.txt");

            // Assert
            result.Should().Be(expectedDiamond);
        }
    }
}