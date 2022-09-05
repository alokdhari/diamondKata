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

        [TestCase("B")]
        [TestCase("C")]
        [TestCase("D")]
        [TestCase("F")]
        public void ShouldBeAbleToPrintDiamond(char midPointCharacter)
        {
            // Arrange
            var expectedDiamond = File.ReadAllText($"./TestFiles/diamond{midPointCharacter}.txt");

            // Act
            var result = new DiamondPrinter().Print(midPointCharacter);

            // Assert
            result.Should().Be(expectedDiamond);
        }
    }
}