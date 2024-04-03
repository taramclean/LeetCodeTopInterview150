using LeetCodeTopInterview150.ArrayString.Easy.MergeSortedArray;

namespace LeetCodeTopInterview150.Tests.ArrayString.Easy.MergeSortedArray;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
        const int m = 3;
        var nums2 = new[] { 2, 5, 6 };
        const int n = 3;

        var target = new Solution();
        var expected = new[] { 1, 2, 2, 3, 5, 6 };

        target.Merge(nums1, m, nums2, n);
        Assert.Equal(expected, nums1);
    }

    [Fact]
    public void Case2()
    {
        var nums1 = new[] { 1 };
        const int m = 1;
        var nums2 = Array.Empty<int>();
        const int n = 0;

        var target = new Solution();
        var expected = new[] { 1 };

        target.Merge(nums1, m, nums2, n);
        Assert.Equal(expected, nums1);
    }

    [Fact]
    public void Case3()
    {
        var nums1 = new[] { 0 };
        const int m = 0;
        var nums2 = new[] { 1 };
        const int n = 1;

        var target = new Solution();
        var expected = new[] { 1 };

        target.Merge(nums1, m, nums2, n);
        Assert.Equal(expected, nums1);
    }
}