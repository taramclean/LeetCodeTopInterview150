namespace LeetCodeTopInterview150.ArrayString.Easy.FindTheIndexOfTheFirstOccurrenceInAString;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        var startIndex = 0;
        var needleEndIndex = needle.Length - 1;
        var endIndex = haystack.Length - needleEndIndex;

        while (startIndex < endIndex)
        {
            if (haystack[startIndex] == needle[0]
                && haystack[startIndex + needleEndIndex] == needle[needleEndIndex])
            {
                var counter = 1;

                for (var i = 1; i <= needleEndIndex; i++)
                {
                    if (haystack[startIndex + i] == needle[i])
                    {
                        counter++;
                    }
                }

                if (counter == needle.Length)
                {
                    return startIndex;
                }
            }

            startIndex++;
        }

        return -1;
    }
}