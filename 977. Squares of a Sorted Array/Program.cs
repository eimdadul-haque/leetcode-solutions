public class Program
{
    public static void Main(string[] args)
    {
        var nums = new int[] { -4, -1, 0, 3, 10 };
        var solution = new Solution();
        var result = solution.SortedSquares(nums);

        foreach (var item in result)
        {
            Console.WriteLine(item.ToString());
        }
    }
}

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int length = nums.Length;
        bool swapped = false;

        for (int i = 0; i < length; i++)
        {
            nums[i] = nums[i] * nums[i];
        }

        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                    swapped = true;
                }

            }

            if (!swapped)
                break;
        }

        return nums;
    }
}


