
Solution solution = new();





Console.WriteLine(string.Join(",", solution.PrefixesDivBy5([1, 1, 0, 0, 0, 1, 0, 0, 1])));
Console.WriteLine(string.Join(",", solution.PrefixesDivBy5([0, 1, 1])));
Console.WriteLine(string.Join(",", solution.PrefixesDivBy5([1, 1, 1])));
//Console.WriteLine(string.Join(",", solution.PrefixesDivBy5([1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0])));
//Console.WriteLine(string.Join(",", solution.PrefixesDivBy5([1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0])));


public class Solution
{
    public IList<bool> PrefixesDivBy5(int[] nums)
    {
       var result = new bool[nums.Length];
        int value = 0;
        for(int i  = 0; i < nums.Length;i++)
        {
            value = (value << 1 + nums[i]) % 5;

            result[i] = (value == 0);
        }

        return result;
    }
}