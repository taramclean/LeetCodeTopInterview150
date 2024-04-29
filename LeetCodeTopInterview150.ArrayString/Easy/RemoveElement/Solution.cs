namespace LeetCodeTopInterview150.ArrayString.Easy.RemoveElement;

public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        var indexPointer = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val) continue;
            nums[indexPointer] = nums[i];
            indexPointer++;
        }

        return indexPointer;
    }
}