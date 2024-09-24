public class Program
{
    public static void Main(string[] args)
    {
        var operations = new string[] { "--X", "X++", "X++" };
        var solution = new Solution();
        var result = solution.FinalValueAfterOperations(operations);
    }
}

public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int output = 0;
        foreach (string operation in operations)
        {
            if ("--X" == operation)
                output--;
            else if ("X++" == operation)
                output++;
            else if ("X--" == operation)
                output--;
            else if ("++X" == operation)
                output++;
        }

        return output;
    }
}