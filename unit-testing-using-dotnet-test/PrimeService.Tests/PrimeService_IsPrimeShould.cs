namespace PrimeService.Tests;

public class PrimeService_IsPrimeShould
{
    [Fact]
    public void IsPrime_Input1_ReturnFalse()
    {
        // Arrange
        var primeService = new PrimeService();

        // Act
        bool result = primeService.IsPrime(1);

        // Assert
        Assert.False(result, "1 should not be prime");
    }
}