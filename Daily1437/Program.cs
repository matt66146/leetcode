namespace Daily1437;

class Program
{
    static void Main(string[] args)
    {
        var solution = new Solution();
        Console.WriteLine(solution.KLengthApart([1, 0, 0, 0, 1, 0, 0, 1], 2));
        Console.WriteLine(solution.KLengthApart([1, 0, 0, 1, 0, 1], 2));
    }
}

public class Solution
{
    public bool KLengthApart(int[] nums, int k)
    {
        for (int i = 0; i < nums.Length;)
        {
            if (nums[i] == 1)
            {
                int places = 0;
                i++;
                if (i >= nums.Length)
                {
                    break;
                }
                while (nums[i] == 0)
                {
                    places++;
                    i++;
                    if (i >= nums.Length)
                    {
                        return true;
                    }

                }
                if (places < k)
                {
                    return false;
                }

            }
            else
            {
                i++;
            }
        }


        return true;
    }

}