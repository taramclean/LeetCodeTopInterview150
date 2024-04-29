namespace LeetCodeTopInterview150.ArrayString.Medium.RemoveDuplicatesFromSortedArrayII;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var indexPointer = 0;
        var count = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[indexPointer] != nums[i])
            {
                nums[++indexPointer] = nums[i];
                count = 0;
            }
            else if (count < 2)
            {
                nums[++indexPointer] = nums[i];
            }

            count++;
        }

        return indexPointer + 1;
    }
}