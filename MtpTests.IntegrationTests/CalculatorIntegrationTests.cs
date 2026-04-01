using Xunit;
using MtpSample.Core;

public class CalculatorIntegrationTests
{
    [Fact]
    public void Divide_ShouldReturnResult()
    {
        var calc = new Calculator();
        Assert.Equal(2, calc.Divide(4, 2));
    }
}