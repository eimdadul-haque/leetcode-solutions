
var nums = new int[] { 1, 3, 5, 7, 2, 4, 6, 8 };
var solution = new Solution();
var result = solution.SortArrayByParity(nums);

foreach (var item in result)
{
    Console.WriteLine(item);   
}


public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        int last = nums.Length - 1, first = 0;
        var newNums = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] % 2 == 0)
            {
                newNums[first] = nums[i];
                first++;
            }
            else
            {
                newNums[last] = nums[i];
                last--;
            }
        }

        return newNums;
    }
}