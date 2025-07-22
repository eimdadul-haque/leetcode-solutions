
var nums = new int[] {1,3,4,5,6,6,6};
var solution = new Solution();
var result = solution.MajorityElement(nums);

public class Solution {
    public int MajorityElement(int[] nums) {
        var dictionary = new Dictionary<int, int>();
        foreach(int num in nums) {
            if(dictionary.ContainsKey(num)){
                dictionary[num] = dictionary[num] + 1;
            }
            else {
                dictionary[num] = 1;
            }
        }

        int key = 0;
        int maxCount = 0;

        foreach (var item in dictionary)
        {
            if (item.Value > maxCount)
            {
                maxCount = item.Value;
                key = item.Key;
            }
        }

        return key;
    }
}