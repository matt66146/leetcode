using System.Diagnostics;

namespace Daily2154;

class Program
{
    static void Main(string[] args)
    {
        var solution = new Solution();
        //Console.WriteLine(solution.FindFinalValue([5, 3, 6, 1, 12], 3));
        //Console.WriteLine(solution.FindFinalValue([2, 7, 9], 4));
        Random rng = new Random();

        int[] shuffled = Enumerable.Range(1, 1000000)
                                  .OrderBy(_ => rng.Next())
                                  .ToArray();

        Stopwatch stopwatch = new();

        stopwatch.Start();
        Console.WriteLine(solution.FindFinalValue(shuffled, 1));
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
        stopwatch.Reset();

        stopwatch.Restart();
        Console.WriteLine(solution.FindFinalValueV2(shuffled, 1));
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
        stopwatch.Reset();

        stopwatch.Restart();
        Console.WriteLine(solution.FindFinalValueV3(shuffled, 1));
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}
public class Solution
{
    public int FindFinalValue(int[] nums, int original)
    {
        while (nums.Contains(original))
        {
            original *= 2;
        }

        return original;
    }
    public int FindFinalValueV2(int[] nums, int original)
    {
        HashSet<int> visited = new HashSet<int>(nums);
        while (visited.Contains(original))
        {
            original *= 2;
        }

        return original;
    }
    public int FindFinalValueV3(int[] nums, int original)
    {
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (original == nums[i])
            {
                original *= 2;
            }
        }

        return original;
    }

    public bool Contains(int[] nums, int num)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == num) return true;
        }
        return false;
    }
}