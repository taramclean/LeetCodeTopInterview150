namespace LeetCodeTopInterview150.ArrayString.Easy.LengthOfLastWord;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var count = 0;

        for (var i=s.Length-1; i >=0; i--)
        {
            if (s[i] != ' ')
            {
                count++;
                if (i == 0 || s[i - 1] == ' ')
                    return count;
            }
        }

        return count;
    }
}