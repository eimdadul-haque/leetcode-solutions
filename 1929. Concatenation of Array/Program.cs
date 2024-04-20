public class Program { 
    public static void Main(string[] args)
    {
        var nums = new int[] { 3, 4, 5 };
        var solution = new Solution();
        var result = solution.GetConcatenation(nums);
    }
}

public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int index = 0;
        var outputArray = new int[nums.Length * 2];
        for (int i = 1; i <= 2; i++)
            foreach (var num in nums)
                outputArray[index++] = num;

        return outputArray;
    }
}

