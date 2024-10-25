namespace PrimeService.Tests;

public class PrimeService_IsPrimeShould
{
    private readonly PrimeService _primeService;

    public PrimeService_IsPrimeShould()
    {
        _primeService = new PrimeService();
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void IsPrime_Input1_ReturnFalse(int value)
    {
        // Arrange

        // Act
        bool result = _primeService.IsPrime(value);

        // Assert
        Assert.False(result, "1 should not be prime");
    }
}