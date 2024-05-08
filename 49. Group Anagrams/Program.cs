public class Program
{
    public static void Main(string[] args)
    {
        var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        var solution = new Solution();
        var result = solution.GroupAnagrams(strs);
    }
}
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dictionary = new Dictionary<string, IList<string>>();
        foreach (var str in strs)
        {
            var chArray = str.ToCharArray();
            Array.Sort(chArray);
            var newStr = new string(chArray);

            if(!dictionary.ContainsKey(newStr))
                dictionary[newStr] = new List<string>();

            dictionary[newStr].Add(str);
        }

        var result = new List<IList<string>>();
        foreach (var item in dictionary)
            result.Add(item.Value);

        return result;
    }
}