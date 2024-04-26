class Program
{
    private Program() { }

    public static Program getProgram()
    {
        return new Program();
    }

    public static void Main()
    {
        var result = getProgram().TwoSum(new int[] {1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1}, 11);
    }

    public int[] TwoSum(int[] nums, int target)
    {
        var twoSumDictionaty = new Dictionary<int, int>();
        int length = nums.Length;

        for (int i = 0; i < length; i++)
        {
            int key = target - nums[i];
            if (twoSumDictionaty.ContainsKey(key))
                return new int[] { twoSumDictionaty[key], i };
            twoSumDictionaty[nums[i]] = i;
        }

        return null;
    }
}
