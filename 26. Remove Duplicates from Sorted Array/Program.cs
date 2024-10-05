var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
var solution = new Solution();
var result = solution.RemoveDuplicates(nums);
Console.WriteLine(result);

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int first = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[first])
            {
                first++;
                nums[first] = nums[i];
            }
        }
        return first + 1;
    }
}