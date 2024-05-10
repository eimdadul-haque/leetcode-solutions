public class Program
{
    public static void Main(string[] args)
    {
        var nums = new int[] { 1, 2, 3, 4 };
        var soluiton = new Solution();                                                                                                                   
        var result = soluiton.ProductExceptSelf(nums);
    }
}


public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int prefix = 1, postfix = 1;
        var result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = prefix;
            prefix = prefix * nums[i];
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] = result[i] * postfix;
            postfix = postfix * nums[i];
        }

        return result;
    }
}