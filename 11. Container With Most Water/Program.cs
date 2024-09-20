var height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
var solution = new Solution();
int result = solution.MaxArea(height);

public class Solution
{
    public int MaxArea(int[] height)
    {
        int water = 0, left = 0, right = height.Length - 1;
        
        while (left < right)
        {
            int diff = (right - left);
            int index = Min(height[left], height[right]);
            int temp = diff * index;
            if (temp > water) water = temp;
            if (height[left] > height[right]) right--;
            else left++;
        }

        return water;
    }

    public int Min(int num1, int num2)
    {
        if (num1 < num2) return num1;
        else return num2;
    }
}