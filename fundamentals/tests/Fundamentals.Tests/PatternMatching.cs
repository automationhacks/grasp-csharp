public class PatternMatchingTest
{
    [Fact]
    public void PatternMatchTest()
    {
        Assert.True(Or(true, true));
        Assert.True(Or(true, false));
        Assert.True(Or(false, true));
        Assert.False(Or(false, false));
    }

    // We can write a single line method
    // that can be invoked and is able to unpack 
    // inputs and resolve to the right case
    public static bool Or(bool left, bool right) =>
        (left, right) switch
        {
            (true, true) => true,
            (true, false) => true,
            (false, true) => true,
            (false, false) => false
        };
    
}