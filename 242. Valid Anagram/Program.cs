using System.Collections.Generic;

class Program {
    private Program() { }
    public static Program getProgram() {
        return new Program();
    }
    public static void Main() {
        var Program = getProgram();
        var result = Program.IsAnagram("123456", "123456");
        Console.WriteLine(result);
        Console.ReadKey();
    }
    public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length) 
            return false;

        Dictionary<char, int> characterCount = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if (characterCount.ContainsKey(c))
                characterCount[c] = characterCount[c] + 1;
            else
                characterCount[c] = 1;
        }

        foreach(char c in t) 
        {
            if (characterCount.ContainsKey(c))
            {
                characterCount[c] = characterCount[c] - 1;
                
                if (characterCount[c] == 0)
                    characterCount.Remove(c);
            }
            else
            {
                return false;
            }
        }

        return characterCount.Count == 0;
    }
}