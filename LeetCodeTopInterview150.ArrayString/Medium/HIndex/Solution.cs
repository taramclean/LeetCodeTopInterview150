namespace LeetCodeTopInterview150.ArrayString.Medium.HIndex;

public class Solution
{
    //O(N)
    public int HIndex(int[] citations)
    {
        var papers = citations.Length;
        var bucket = new int[papers + 1];

        foreach (var c in citations)
        {
            if (c >= papers)
            {
                bucket[papers]++;
            }
            else
            {
                bucket[c]++;
            }
        }

        var index = bucket.Length - 1;
        var sum = 0;

        while (index > sum + bucket[index])
        {
            sum += bucket[index];
            index--;
        }

        return index;
    }

    //O(NLogN)
    /*public int HIndex(int[] citations) {
        Array.Sort(citations);
        
        var n = citations.Length - 1;
        var index = 0;

        while (index <= n && citations[n - index] > index)
        {
            index++;
        }

        return index;
    }*/
    
    //O(NLogN
    /*public int HIndex(int[] citations) {
        Array.Sort(citations);
        Array.Reverse(citations);
   
        for (var i = 0; i < citations.Length; i++)
        {
             if(i >= citations[i])
             {
                 return i;
             }
        }

        return citations.Length;
    }*/
}