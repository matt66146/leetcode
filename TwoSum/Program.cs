Console.WriteLine(string.Join(", ", TwoSum(new int[] { 2, 7, 11, 15 }, 9)));


int[] TwoSumGarbo(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return new int[] { i, j };
            }
        }

    }
    throw new Exception("This shouldn't be possible");
}
int[] TwoSum(int[] nums, int target)
{
    var dict = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int j;
        if (dict.TryGetValue(nums[i], out j))
        {
            return [i, j];
        }
        else
        {
            int compliment = target - nums[i];
            dict.TryAdd(compliment, i);
        }
    }

    throw new Exception("This shouldn't be possible");
}