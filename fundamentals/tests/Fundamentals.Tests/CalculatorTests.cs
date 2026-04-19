using Fundamentals;

namespace Fundamentals.Tests;

public class CalculatorTests
{
    [Fact]
    public void AddTest()
    {
        var calculator = new Calculator();
        Assert.Equal(10, calculator.Add(5, 5));
    }
}
