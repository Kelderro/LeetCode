namespace LeetCode.Problem33;

using FluentAssertions;
using Xunit;

public class SolutionTests
{
    [Theory]

    // [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    // [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
    // [InlineData(new[] { 1 }, 0, -1)]
    // [InlineData(new[] { 3, 1 }, 0, -1)]
    [InlineData(new[] { 5, 1, 3 }, 0, -1)]
    public void Search_OnProvidingExampleCases_ReturnExpectedOutput(int[] nums, int target, int expected)
    {
        // Arrange
        var problem = new Solution();

        // Act
        var result = problem.Search(nums, target);

        // Assert
        result.Should().Be(expected);
    }
}
