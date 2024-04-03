namespace LeetCodeTopInterview150.ArrayString.Easy.LongestCommonPrefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var baseWord = strs[0];

        for (var i = 0; i < baseWord.Length; i++)
        {
            for (var j = 1; j < strs.Length; j++)
            {
                var word = strs[j];
                if (i == word.Length || baseWord[i] != word[i])
                {
                    return baseWord.Substring(0, i);
                }
            }
        }
        
        return baseWord;
    }
}