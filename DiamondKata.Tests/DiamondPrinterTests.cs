using FluentAssertions;

namespace DiamondKata.Tests
{
    public class DiamondPrinterTests
    {
        [Test]
        public void ShouldPrintDiamondOfOneDepth()
        {
            // Arrange
            var midPointCharacter = 'A';

            // Act
            var result = new DiamondPrinter(midPointCharacter).Print();

            // Assert
            result.Should().Be(midPointCharacter.ToString());
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
            var result = new DiamondPrinter(midPointCharacter).Print();

            // Assert
            result.Should().Be(expectedDiamond);
        }
    }
}