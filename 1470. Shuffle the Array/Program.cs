public class Program {
    public static void Main(string[] args) {
        int[] nums = new int[]{2,5,1,3,4,7};
        int n = 3;
        var solution = new Solution();
        var result = solution.Shuffle(nums, n);
    }
}

public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        var result = new int[nums.Length];
        var mid = (nums.Length) / 2;
        for (int i = 0; i < mid; i++)
        {
            result[2 * i] = nums[i];
            result[2 * i + 1] = nums[mid + i];
        }

        return result;
    }
}