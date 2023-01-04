namespace LeetCode.Problem91;

using FluentAssertions;
using Xunit;

public class SolutionTests
{
    [Theory]
    [InlineData("12", 2)]
    [InlineData("226", 3)]
    [InlineData("06", 0)]
    public void NumDecodings_OnProvidingExampleCases_ReturnExpectedOutput(string s, int expected)
    {
        // Arrange
        var problem = new Solution();

        // Act
        var result = problem.NumDecodings(s);

        // Assert
        result.Should().Be(expected);
    }
}
