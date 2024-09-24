public class Program
{
    public static void Main(string[] args)
    {
        var nums = new int[] { 1, 1, 1, 1 };
        var solution = new Solution();
        var result = solution.NumIdenticalPairs(nums); ;
    }
}
public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        int output = 0;
        for (int i = 0; i < nums.Length; i++)
            for(int j = 0; j < nums.Length; j++)
                if (nums[i] == nums[j] && i < j)
                    output++;
        return output;
    }
}
