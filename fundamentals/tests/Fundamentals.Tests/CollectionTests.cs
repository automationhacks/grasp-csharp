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
}