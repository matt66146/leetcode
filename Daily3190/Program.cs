namespace Daily3190;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.MinimumOperations([1, 2, 3, 4]));
        Console.WriteLine(solution.MinimumOperations([3, 6, 9]));
    }
}
public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        int numOperations = 0;

        foreach (int num in nums)
        {
            if (num % 3 != 0)
            {
                numOperations++;
            }
        }

        return numOperations;
    }
}