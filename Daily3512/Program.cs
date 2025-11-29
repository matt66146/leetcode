namespace Daily3512;

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.MinOperations2([3, 9, 7], 5));
    }
}

public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        int sum = 0;
        foreach (var num in nums)
            sum += num;
        return sum % k;
    }
    public int MinOperations2(int[] nums, int k)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum - (sum / k) * k;
    }

}