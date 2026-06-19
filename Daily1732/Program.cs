Solution solution = new();
Console.WriteLine(solution.LargestAltitude([-4, -3, -2, -1, 4, 3, 2]));
public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        int highest = 0;
        int current = 0;
        foreach (int num in gain)
        {
            current += num;
            if (current > highest) highest = current;
        }

        return highest;
    }
}