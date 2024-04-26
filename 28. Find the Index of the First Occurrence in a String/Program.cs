class Program
{
    private Program() { }

    public static Program getProgram()
    {
        return new Program();   
    }

    public static void Main(string[] args)
    {
        int resut = getProgram().StrStr("leetcode", "leeto");
    }

    public int StrStr(string haystack, string needle)
    {
        char[] needleArrsy = needle.ToCharArray();
        char[] haystackArray = haystack.ToCharArray();

        for (int i = 0; i < haystackArray.Length; i++)
        {
            if (needleArrsy[i] != )
        }

        return 0;
    }
}