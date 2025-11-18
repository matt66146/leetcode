namespace Daily717;

class Program
{
    static void Main(string[] args)
    {
        var solution = new Solution();

        Console.WriteLine(solution.IsOneBitCharacter([1, 0, 0]));
        Console.WriteLine(solution.IsOneBitCharacter([1, 1, 1, 0]));

    }
}
public class Solution
{
    public bool IsOneBitCharacter(int[] bits)
    {


        for (int i = 0; i < bits.Length; i++)
        {

            if (bits[i] == 1)
            {
                i++;
            }
            else
            {
                if (i == bits.Length - 1) return true;
            }
        }
        return false;

    }
    public bool IsOneBitCharacterV2(int[] bits)
    {
        int ones = 0;

        for (int i = bits.Length - 2; i >= 0 && bits[i] != 0; i--)
        {
            ones++;
        }
        if (ones % 2 != 0) return false;
        return true;
    }
}