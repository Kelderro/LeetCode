namespace LeetCode.Problem91;

/// <summary>
/// 91. Decode Ways
/// https://leetcode.com/problems/decode-ways/.
/// </summary>
public class Solution
{
    private int strLength;

    public int NumDecodings(string s)
    {
        this.strLength = s.Length;
        return this.BackTrack(s, 0);
    }

    public int BackTrack(string s, int offset)
    {
        if (offset >= this.strLength)
        {
            return 1;
        }

        if (s[offset] == '0')
        {
            return 0;
        }

        int counta = 0, countb = 0;

        // Check for index 1 - 9
        counta = this.BackTrack(s, offset + 1);

        // Check for index 10 till 26
        if (offset <= this.strLength - 2 && Convert.ToInt32(s.Substring(offset, 2)) <= 26)
        {
            countb = this.BackTrack(s, offset + 2);
        }

        return counta + countb;
    }
}