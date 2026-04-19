using Fundamentals;

namespace Fundamentals.Tests;

public class CalculatorTests
{
    [Fact]
    public void AddTest()
    {
        var calculator = new Calculator();
        Assert.Equal(calculator.Add(5, 5), 10);
    }
}
