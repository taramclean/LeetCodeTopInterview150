namespace LeetCodeTopInterview150.ArrayString.Medium.JumpGame2;

public class Solution
{
    public int Jump(int[] nums)
    {
        var result = 0;
        var left = 0;
        var right = 0;

        while (right < nums.Length - 1)
        {
            var furthest = 0;
            for (var i = left; i <= right; i++)
            {
                furthest = Math.Max(furthest, i + nums[i]);
            }

            left = right + 1;
            right = furthest;
            result += 1;
        }

        return result;
    }
}