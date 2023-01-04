namespace LeetCode.Problem21;

/// <summary>
/// 21. Merge Two Sorted Lists
/// https://leetcode.com/problems/merge-two-sorted-lists/.
/// </summary>
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
        {
            return list2;
        }

        if (list2 == null)
        {
            return list1;
        }

        if (list2.Val > list1.Val)
        {
            list1.Next = this.MergeTwoLists(list1.Next, list2);
            return list1;
        }

        list2.Next = this.MergeTwoLists(list1, list2.Next);
        return list2;
    }
}
