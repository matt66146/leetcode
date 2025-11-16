namespace Daily1513;

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();

        Console.WriteLine(s.NumSub("0110111"));
    }
}


public class Solution
{
    public int NumSub(string s)
    {
        int mod = (int)Math.Pow(10, 9) + 7;
        long output = 0;
        long c = 0;
        foreach (var num in s)
        {
            if (num == '1')
            {
                c++;
            }
            else
            {
                output += c * (c + 1) / 2;
                output %= mod;
                c = 0;
            }
        }
        output += c * (c + 1) / 2;
        output %= mod;
        c = 0;
        return (int)output;
    }
}
