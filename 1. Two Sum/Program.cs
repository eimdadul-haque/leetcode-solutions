public class Program
{
    public static void Main(string[] args) {
        Program program = new();
        var res = program.TwoSum(new int[]{2,7,11,15}, 9);
    }
    
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> indices = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            if (indices.ContainsKey(difference))
            {
                return new int[] {indices[difference], i};
            }

            indices[nums[i]] = i;
        }

        return nums;
    }
}