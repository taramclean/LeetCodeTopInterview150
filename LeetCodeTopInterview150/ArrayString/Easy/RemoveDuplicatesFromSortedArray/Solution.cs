namespace LeetCodeTopInterview150.ArrayString.Easy.RemoveDuplicatesFromSortedArray;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var indexPointer = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[indexPointer]) continue;
            indexPointer++;
            nums[indexPointer] = nums[i];
        }

        return indexPointer + 1;
    }
}