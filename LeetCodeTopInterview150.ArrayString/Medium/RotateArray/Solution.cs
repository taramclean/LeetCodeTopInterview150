namespace LeetCodeTopInterview150.ArrayString.Medium.RotateArray;

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        var n = nums.Length;
        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, n - 1);
    }

    private void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }
    }
}