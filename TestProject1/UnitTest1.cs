using ApiApp;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public async void Test1()
    {
        await PostHttpTrigger.GetPostsAsync(null, null);
    }
}