public class Program
{
    private Program() { }
    public static Program GetObject()
    {
        return new Program();
    }
    public static void Main(string[] args)
    {
        var result = GetObject().ReverseArry(new int[] { 1, 3, 5, 7, 8});
    }

    public int[] ReverseArry(int[] nums)
    {

        for (int firstIndex = 0; firstIndex < nums.Length; firstIndex++)
        {
            int lastIndex = (nums.Length - 1) - firstIndex;
            if (lastIndex <= firstIndex)
                break;
            int temp = nums[firstIndex];
            nums[firstIndex] = nums[lastIndex];
            nums[lastIndex] = temp;
        }

        return nums;
    }
}