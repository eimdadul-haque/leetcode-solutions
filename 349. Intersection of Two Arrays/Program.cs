var nums1 = new int[] { 1, 2, 2, 1 };
var nums2 = new int[] { 2, 2 };

var solution = new Solution();
var result = solution.Intersection(nums1, nums2);


public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var temp = new List<int>();
        foreach (var num1 in nums1)
        {
            foreach (var num2 in nums2)
            {
                if(num1 == num2)
                {
                    temp.Add(num1);   
                }
            }
        }

        var result = new List<int>();
        foreach (var item in temp)
        {
            if (!result.Contains(item))
            {
                result.Add(item);
            }
        }

        return result.ToArray();
    }
}