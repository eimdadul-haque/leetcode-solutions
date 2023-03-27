class Program
{
    public static void Main(string[] args)
    {
        MoveZeroes(new int[] { 1, 0, 1 });
    }

    public static void MoveZeroes(int[] nums)
    {
        int left = 0;
        if (nums.Length < 2) return;

        for (int right = 1; right < nums.Length; right++)
        {
            if (nums[left] != 0)
                left++;
            else if (nums[right] == 0)
                continue;
            else
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
            }
        }
    }
}