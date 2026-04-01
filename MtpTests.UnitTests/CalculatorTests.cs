using Xunit;
using MtpSample.Core;

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnSum()
    {
        var calc = new Calculator();
        Assert.Equal(5, calc.Add(2, 3));
    }
}