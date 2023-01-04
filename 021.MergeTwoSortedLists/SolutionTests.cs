namespace LeetCode.Problem21;

using FluentAssertions;
using Xunit;

public class SolutionTests
{
    [Theory]
    [InlineData(new[] { 1, 3, 4 }, new[] { 2, 4, 6 }, new[] { 1, 2, 3, 4, 4, 6 })]
    [InlineData(new int[0], new int[0], new int[0])]
    [InlineData(new int[0], new[] { 0 }, new[] { 0 })]
    public void MergeTwoLists_OnProvidingExampleCases_ReturnExpectedOutput(int[] list1, int[] list2, int[] expected)
    {
        // Arrange
        var problem = new Solution();

        // Act
        var result = problem.MergeTwoLists(this.Parse(list1), this.Parse(list2));

        // Assert
        this.Parse(result).Should().Equal(expected);
    }

    private ListNode Parse(int[] arr)
    {
        if (arr.Length == 0)
        {
            return null!;
        }

        var startNode = new ListNode
        {
            Val = arr[0],
        };
        var node = startNode;

        foreach (var nodeValue in arr.Skip(1))
        {
            node.Next = new ListNode
            {
                Val = nodeValue,
            };
            node = node.Next;
        }

        return startNode;
    }

    private int[] Parse(ListNode node)
    {
        var result = new List<int>();

        while (node != null)
        {
            result.Add(node.Val);
            node = node.Next;
        }

        return result.ToArray();
    }
}