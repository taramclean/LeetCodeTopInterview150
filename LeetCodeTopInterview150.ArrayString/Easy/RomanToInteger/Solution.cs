namespace LeetCodeTopInterview150.ArrayString.Easy.RomanToInteger;

public class Solution
{
    public int RomanToInt(string s)
    {
        var mapping = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        var result = mapping[s[^1]];

        for (var i = s.Length - 2; i >= 0; i--)
        {
            if (mapping[s[i]] < mapping[s[i + 1]])
            {
                result -= mapping[s[i]];
            }
            else
            {
                result += mapping[s[i]];
            }
        }

        return result;
    }
}