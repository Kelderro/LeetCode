namespace LeetCode.Problem104;

using FluentAssertions;
using Xunit;

public class SolutionTests
{
    [Theory]
    [InlineData(new[] { 3, 9, 20, int.MinValue, int.MinValue, 15, 7 }, 3)]
    [InlineData(new[] { 1, int.MinValue, 2 }, 2)]
    public void Search_OnProvidingExampleCases_ReturnExpectedOutput(int[] nums, int expected)
    {
        // Arrange
        var problem = new Solution();

        // Act
        var result = problem.MaxDepth(this.Parse(nums, 0));

        // Assert
        result.Should().Be(expected);
    }

    private TreeNode Parse(int[] arr, int i)
    {
        TreeNode root = null!;

        if (i < arr.Length)
        {
            if (arr[i] == int.MinValue)
            {
                return null!;
            }

            root = new TreeNode(arr[i]);

            root.Left = this.Parse(arr, (2 * i) + 1);
            root.Right = this.Parse(arr, (2 * i) + 2);
        }

        return root;
    }
}
