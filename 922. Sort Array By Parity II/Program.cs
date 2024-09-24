// https://leetcode.com/problems/sort-array-by-parity-ii/description/ 
var nums = new int[] { 4, 2, 5, 7, 4, 7 };
var solution = new Solution();
var result = solution.SortArrayByParityII(nums);

foreach (var item in result)
{
    Console.WriteLine(item);
}

public class Solution
{
    public int[] SortArrayByParityII(int[] nums)
    {
        var newNums = new int[nums.Length];
        int first = 0, last = nums.Length - 1;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
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

        var result = new int[newNums.Length];
        int mid = (nums.Length / 2);
        int indexOne = 1, indexTwo = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i < mid)
            {
                result[indexTwo] = newNums[i];
                indexTwo += 2;
            }
            else
            {
                result[indexOne] = newNums[i];
                indexOne += 2;
            }
        }

        return result;
    }

}