namespace Daily1930;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.CountPalindromicSubsequence("aabca"));
        Console.WriteLine(solution.CountPalindromicSubsequence("adc"));
        Console.WriteLine(solution.CountPalindromicSubsequence("bbcbaba"));
    }
}
class Solution
{
    public int CountPalindromicSubsequence(String s)
    {
        List<char> charsChecked = new();
        HashSet<string> subSequences = new();
        for (int i = 0; i < s.Length; i++)
        {
            char start = s[i];
            if (charsChecked.Contains(start)) continue;
            charsChecked.Add(start);
            for (int j = s.Length - 1; j >= 0; j--)
            {
                if (s[j] == start)
                {
                    for (int k = j - 1; k > i; k--)
                    {
                        string subSequence = string.Join("", start, s[k], s[j]);
                        subSequences.Add(subSequence);
                    }
                    break;
                }
            }
        }
        return subSequences.Count;
    }
}