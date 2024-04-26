class Program
{
    public static void Main(string[] args)
    {
        var res = MajorityElement(new int[] { 2, 2, 1, 3, 4, 6, 8 });
    }

    public static int MajorityElement(int[] nums)
    {
        int majorityElement = 0,
            count = 0;

        foreach(int num in nums)
        {
            if (count.Equals(0))
                majorityElement = num;
            if (majorityElement.Equals(num))
                count++;
            else
                count--;
        }

        return majorityElement;
    }
}