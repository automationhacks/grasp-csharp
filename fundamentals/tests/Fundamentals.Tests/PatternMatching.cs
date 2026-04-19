public class PatternMatchingTest
{
    [Fact]
    public void PatternMatchOrTest()
    {
        Assert.True(Or(true, true));
        Assert.True(Or(true, false));
        Assert.True(Or(false, true));
        Assert.False(Or(false, false));
    }

    [Fact]
    public void PatternMatchAndTest()
    {
        Assert.True(ReducedAnd(true, true));
        Assert.False(ReducedAnd(true, false));
        Assert.False(ReducedAnd(false, true));
        Assert.False(ReducedAnd(false, false));
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

    public static bool ReducedAnd(bool left, bool right) =>
        (left, right) switch
        {
            (true, true) => true,
            // We can use use _ as a catch all for the remaining cases
            (_, _) => false
        };

}