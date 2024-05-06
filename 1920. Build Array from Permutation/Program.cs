public class Program {
    public static void Main(string[] args) {
        var nums = new int[] { 0, 2, 1, 5, 3, 4 };
        var solution = new Solution();
        var result = solution.BuildArray(nums); ;
    }
}

public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        int[] result = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
            result[i] = nums[nums[i]];
        return nums;
    }
}