namespace DevOpsVersionApp.Tests;

using Xunit;

public class AppTests
{
    [Fact]
    public void GetVersion_ReturnsValidVersion()
    {
        string version = Program.GetVersion();

        Assert.Matches(@"^\d+\.\d+\.\d+$", version);
    }

    [Fact]
    public void GetVersion_ReturnsNonEmptyString()
    {
        string version = Program.GetVersion();

        Assert.False(string.IsNullOrWhiteSpace(version));
    }
}