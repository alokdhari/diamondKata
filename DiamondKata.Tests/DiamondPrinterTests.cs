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

            result.ShouldBe(character.ToString());
        }
    }
}