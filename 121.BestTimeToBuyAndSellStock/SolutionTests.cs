namespace LeetCode.Problem121;

using FluentAssertions;
using Xunit;

public class SolutionTests
{
    [Theory]
    //[InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    //[InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
    [InlineData(new[] { 2, 4, 1 }, 2)]
    public void MaxProfit_OnProvidingExampleCases_ReturnExpectedOutput(int[] prices, int expected)
    {
        // Arrange
        var problem = new Solution();

        // Act
        var result = problem.MaxProfit(prices);

        // Assert
        result.Should().Be(expected);
    }
}
