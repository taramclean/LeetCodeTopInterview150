namespace LeetCodeTopInterview150.ArrayString.Medium.JumpGame;

public class Solution
{
    public bool CanJump(int[] nums)
    {
        var goal = nums.Length - 1;

        for (var i = nums.Length - 2; i >= 0; i--)
        {
            if (i + nums[i] >= goal)
            {
                goal = i;
            }
        }
        
        return goal == 0 ? true : false;
    }
}