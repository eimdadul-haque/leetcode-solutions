public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        for(int i = 0;  i < nums.Length; i++)
        {
            if (val != nums[i])
            {
                nums[k] = nums[i];
                k += 1;
            }     
        }
        
        return k;
    }
}