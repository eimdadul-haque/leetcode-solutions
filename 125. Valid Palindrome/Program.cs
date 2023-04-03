public class Program
{
    public static void Main(string[] args)
    {
        var res = IsPalindrome("race a car");
    }

    public static bool IsPalindrome(string s)
    {
        int left = 0,
            right = s.Length- 1;

        while(left < right) 
        {
            while(left < right && !IsAlphanumeric(s[left]))
                left++;
            while (right > left && !IsAlphanumeric(s[right]))
                right--;
            if (s[right].ToString().ToLower() 
                != s[right].ToString().ToLower())
                return false;
            left++; right--;
        }

        return true;
    }

    public static bool IsAlphanumeric(char ch)
    {
        if('A' <= ch && ch <= 'Z' 
            || 'a' <= ch && ch <= 'z'
            || '0' <= ch && ch <= '9' )
            return true;
        return false;
    }
}