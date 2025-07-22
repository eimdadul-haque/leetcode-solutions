
var nums = new int[] { 1,2 };
int k = 7;

var solution = new Solution();
solution.Rotate(nums, k);

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        if (nums.Length == 0 || nums.Length == 1)
            return;

        int[] temp = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            temp[(i + k) % temp.Length] = nums[i];
        }

        for (int i = 0; i < temp.Length; i++)
            nums[i] = temp[i];
        
        Console.WriteLine(string.Join(',', nums));
    }
}