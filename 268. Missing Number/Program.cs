
var nums = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
var solution = new Solution();
int result = solution.MissingNumber(nums);
int a = result;
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int gSum = n * (n + 1) / 2;
        int sum = 0;

        foreach (var num in nums)
        {
            sum = sum + num;
        }

        return gSum - sum;
    }
}