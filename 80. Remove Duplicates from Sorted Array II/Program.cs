var nums = new int[] { 1, 1, 1, 2, 2, 3 };
var solution = new Solution();
var resutl = solution.RemoveDuplicates(nums);
Console.WriteLine(resutl);


public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 0;
        var dictionary = new Dictionary<int, int>();
        
        for (int i = 0;i < nums.Length; i++)
        {
            if (dictionary.ContainsKey(nums[i]))
            {
                if (dictionary[nums[i]] < 2)
                {
                    dictionary[nums[i]] = dictionary[nums[i]] + 1;
                }
            }
            else
            {
                dictionary[nums[i]] = 1;
            }
        }

        foreach(var item in dictionary)
        {
            k = k + item.Value;
        }

        int index = 0;

        foreach (var item in dictionary)
        {
            if (item.Value == 2)
            {
                nums[index] = item.Key;
                index++;
                nums[index] = item.Key;
                index++;
            }
            else
            {
                nums[index++] = item.Key;
            }
        }

        return k;
    }
}