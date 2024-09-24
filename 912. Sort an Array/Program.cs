/* https://leetcode.com/problems/sort-array-by-parity-ii/description/ */

var nums = new int[] { 5, 2, 3, 1 };
var solution = new Solution();
var result = solution.SortArray(nums);

foreach (var item in result)
{
    Console.WriteLine(item);
}

public class Solution
{
    public int[] SortArray(int[] nums)
    {
        Sort(nums, new int[nums.Length], 0, nums.Length -1);
        return nums;
    }

    private void Sort(int[] nums, int[] tempNums, int low, int high)
    {
        if (low < high)
        {
            int mid = low + (high - low) / 2;
            Sort(nums, tempNums, low, mid);
            Sort(nums, tempNums, mid + 1, high);
            Marge(nums, tempNums, low, mid, high);
        }
    }

    private void Marge(int[] nums, int[] tempNums, int low, int mid, int high)
    {
        for (int index = low; index <= high; index++) 
        {
            tempNums[index] = nums[index];
        }

        int i = low;
        int j = mid + 1;
        int k = low;

        while (i <= mid && j <= high)
        {
            if(tempNums[i] < tempNums[j])
                nums[k] = tempNums[i++];
            else
                nums[k] = tempNums[j++];
            k++;
        }

        while (i <= mid)
        {
            nums[k] = tempNums[i++];
            k++;
        }
    }
}


