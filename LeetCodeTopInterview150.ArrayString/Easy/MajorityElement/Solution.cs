namespace LeetCodeTopInterview150.ArrayString.Easy.MajorityElement;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var seen = new Dictionary<int, int>();
        var majority = nums.Length / 2;

        for (var i = 0; i < nums.Length; i++)
        {
            if (seen.ContainsKey(nums[i]))
            {
                seen[nums[i]]++;
            }
            else
            {
                seen.Add(nums[i], 1);
            }

            if (seen[nums[i]] > majority)
            {
                return nums[i];
            }
        }

        return -1;
    }
}