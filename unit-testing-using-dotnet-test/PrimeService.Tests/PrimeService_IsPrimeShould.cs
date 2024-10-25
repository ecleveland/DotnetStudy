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
    public void IsPrime_InputBelow2_ReturnFalse(int value)
    {
        // Arrange

        // Act
        bool result = _primeService.IsPrime(value);

        // Assert
        Assert.False(result, "Anything below 2 should not be prime");
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
    {
        // Arrange
        // Act
        bool result = _primeService.IsPrime(value);
        // Assert

        Assert.True(result, "Success");
    }

    [Theory]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(9)]
    public void IsPrime_NonPrimesLessThan10_ReturnFalse(int value)
    {
        // Arrange
        // Act
        bool result = _primeService.IsPrime(value);
        // Assert
        Assert.False(result, "Success");
    }
}