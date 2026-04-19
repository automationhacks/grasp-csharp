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

    [Fact]
    public void SubtractTest()
    {
        var calculator = new Calculator();
        // Failing test example
        Assert.Equal(-1, calculator.Subtract(5, 5));
    }
}
