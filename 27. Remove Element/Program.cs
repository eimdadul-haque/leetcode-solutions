class Program
{
    private Program() { }

    public static Program getProgram()
    {
        return new Program();
    }

    public static void Main(string[] args)
    {
        var resutl = getProgram().RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
    }

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