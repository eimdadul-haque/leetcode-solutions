var nums = new int[] {3,2,2,3};
int val = 3;
var solution = new Solution();
var result = solution.RemoveElement(nums, val);
Console.WriteLine($"Result: {result}");


public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != val){
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}
