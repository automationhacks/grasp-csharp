public class CollectionTests
{
   [Fact]
   public void ListTests()
    {
        int[] numbers = [1, 2, 3, 4, 5];
        Assert.Equal(3, numbers[2]);
    } 

    [Fact]
    public void ListStringTest()
    {
        List<string> names = ["Alice", "Bob", "Sam"];
        Assert.Equal(3, names.Count);
    }

    [Fact]
    public void SpreadOperatorTest()
    {
        int[] numbers = [1, 2, 3, 4, 5];
        int[] anotherNumbers = [.. numbers, 6, 7, 8, 9, 10];
        Assert.Equal(1, anotherNumbers[0]);
        // Here ^1 refers to the last number in the collection
        Assert.Equal(10, anotherNumbers[^1]);
        // Use .. to define a range
        Assert.Equal([2, 3, 4], anotherNumbers[1..4]);
    }
}