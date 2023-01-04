namespace LeetCode.Problem104;

public class TreeNode
{
    public TreeNode(int val = 0, TreeNode left = null!, TreeNode right = null!)
    {
        this.Val = val;
        this.Left = left;
        this.Right = right;
    }

    public int Val { get; set; }

    public TreeNode Left { get; set; }

    public TreeNode Right { get; set; }
}
