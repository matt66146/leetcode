
/*
Console.WriteLine(Solution.MinCost("abaac", [1, 2, 3, 4, 5]));
Console.WriteLine(Solution.MinCost("abc", [1, 2, 3]));
Console.WriteLine(Solution.MinCost("aabaa", [1, 2, 3, 4, 1]));
*/
Console.WriteLine(Solution.MinCost("bbbaaa", [4, 9, 3, 8, 8, 9]));

public class Solution
{
    public static int MinCost(string colors, int[] neededTime)
    {
        int totalTime = 0;
        for (int i = 0; i < neededTime.Length - 1;)
        {
            int j = i;
            while (colors[j] == colors[j + 1])
            {
                j++;
                if (j == neededTime.Length - 1) break;
            }
            if (j > i)
            {
                int highest = i;
                for (int k = i + 1; k <= j; k++)
                {
                    if (neededTime[k] > neededTime[highest]) highest = k;
                }
                for (int k = i; k <= j; k++)
                {
                    if (k != highest)
                    {
                        totalTime += neededTime[k];
                    }
                }
            }
            i += j - i + 1;
        }


        return totalTime;
    }
}