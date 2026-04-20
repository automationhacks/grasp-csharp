namespace Fundamentals.Tests;

public class AsyncAwaitTests
{
    [Fact]
    public async Task AsyncAwaitTest()
    {
        var pageLength = await GetPageLengthAsync("https://www.google.com");
        Assert.True(pageLength > 0);
    }

    public static async Task<int> GetPageLengthAsync(String url)
    {
        var client = new HttpClient();
        var uri = new Uri(url);
        byte[] content = await client.GetByteArrayAsync(uri);
        return content.Length;
    }
}