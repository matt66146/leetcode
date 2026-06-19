Solution solution = new();

Console.WriteLine(solution.AngleClock(12, 30));



public class Solution
{
    public double AngleClock(int hour, int minutes)
    {

        var answer = Math.Abs((30 * hour) - (5.5 * minutes));
        Console.WriteLine(answer);
        if (answer > 180) answer = 360 - answer;
        return answer;
    }
}