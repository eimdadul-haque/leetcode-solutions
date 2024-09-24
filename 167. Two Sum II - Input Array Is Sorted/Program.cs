
var numbers = new int[] { 0, 0, 3, 4 };
Console.WriteLine("input: {0}", string.Join(", ", numbers));
int target = 0;
var solution = new Solution();
var result = solution.TwoSum(numbers, target);
Console.WriteLine("Output: " + string.Join(", ", result));

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var dictionary = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++) 
        { 
            int remain = target - numbers[i];
            if(dictionary.ContainsKey(remain))
            {
               return new int[] { dictionary[remain] + 1, i + 1 };
            }
            else
            {
                dictionary[numbers[i]] = i;
            }
        }

        return numbers;
    }
}