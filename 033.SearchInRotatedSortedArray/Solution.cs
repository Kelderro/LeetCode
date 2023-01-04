namespace LeetCode.Problem33;

/// <summary>
/// 33. Search in Rotated Sorted Array
/// https://leetcode.com/problems/search-in-rotated-sorted-array/.
/// </summary>
public class Solution
{
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        var mid = 0;

        while (left <= right)
        {
            mid = left + ((right - left) / 2);

            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] >= nums[left])
            {
                if (target >= nums[left] && target < nums[mid])
                {
                    right = mid - 1;
                    continue;
                }

                left = mid + 1;
                continue;
            }

            if (target > nums[mid] && target <= nums[right])
            {
                if (target > nums[mid] && target <= nums[right])
                {
                    left = mid + 1;
                    continue;
                }

                right = mid - 1;
            }
        }

        return -1;
    }
}