namespace LeetCodeTopInterview150.ArrayString.Easy.MergeSortedArray;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var firstArrayIndex = m - 1;
        var secondArrayIndex = n - 1;
        var lastIndex = m + n - 1;

        while (secondArrayIndex >= 0)
        {
            if (firstArrayIndex >= 0 && nums1[firstArrayIndex] > nums2[secondArrayIndex])
            {
                nums1[lastIndex--] = nums1[firstArrayIndex--];
            }
            else
            {
                nums1[lastIndex--] = nums2[secondArrayIndex--];
            }
        }
    }
}