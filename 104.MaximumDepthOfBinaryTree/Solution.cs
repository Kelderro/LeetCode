namespace LeetCode.Problem104;

/// <summary>
/// 104. Maximum Depth of Binary Tree
/// https://leetcode.com/problems/maximum-depth-of-binary-tree/.
/// </summary>
public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        return Math.Max(this.MaxDepth(root.Left), this.MaxDepth(root.Right)) + 1;
    }
}