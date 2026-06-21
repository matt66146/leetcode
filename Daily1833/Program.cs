Solution solution = new();

Console.WriteLine(solution.MaxIceCream([10, 6, 8, 7, 7, 8], 5));


public class Solution
{
    public int MaxIceCream(int[] costs, int coins)
    {
        costs.Sort();
        int total = 0;
        foreach (var icecream in costs)
        {
            if (icecream <= coins)
            {
                coins -= icecream;
                total++;
            }
            else
            {
                break;
            }
        }

        return total;
    }
}