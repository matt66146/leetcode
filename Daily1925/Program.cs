
Solution solution = new();

Console.WriteLine(solution.CountTriples(5));
Console.WriteLine(solution.CountTriples(10));


public class Solution
{
    public int CountTriples(int n)
    {
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == j) continue;
                var num = Math.Sqrt((i * i) + (j * j));
                if (num <= n && num % 1 == 0)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}