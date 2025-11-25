namespace Daily1015;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        //Console.WriteLine(solution.SmallestRepunitDivByK(1));
        //Console.WriteLine(solution.SmallestRepunitDivByK(2));
        Console.WriteLine(solution.SmallestRepunitDivByKV2(3));
        // Console.WriteLine(solution.SmallestRepunitDivByK(8));
        //Console.WriteLine(solution.SmallestRepunitDivByK(11));
        //Console.WriteLine(solution.SmallestRepunitDivByK(17));
        //Console.WriteLine(solution.SmallestRepunitDivByK(24));
    }
}
public class Solution
{
    public int SmallestRepunitDivByK(int k)
    {

        int currentMod = 0;
        HashSet<int> prevMods = new(k);
        int length = 0;
        do
        {
            prevMods.Add(currentMod);
            currentMod = ((currentMod * 10) + 1) % k;
            length++;
            if (currentMod == 0)
            {
                return length;
            }

        } while (!prevMods.Contains(currentMod));
        return -1;
    }

    public int SmallestRepunitDivByKV2(int k)
    {
        int prev = 0;
        for (int i = 1; i <= k; i++)
        {
            prev = ((prev * 10) + 1) % k;
            if (prev == 0)
            {
                return i;
            }
        }
        return -1;
    }
    public int SmallestRepunitDivByKOP(int k)
    {
        if (k % 2 == 0 || k % 5 == 0)
            return -1;

        var length = 1;
        var mod = 1 % k;
        while (mod != 0 && length > 0)
        {
            mod = (mod * 10 + 1) % k;
            ++length;
        }

        return length > 0 ? length : -1;
    }
}