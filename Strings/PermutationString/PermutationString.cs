namespace Strings;

public class PermutationString
{
    public bool IsPermutated(string s1, string s2)
    { 
        if (s1.Length != s2.Length) return false;

        int[] letters = new int[128]; // ASCII

        foreach (char letter in s1.ToCharArray())
        {
            int letterCode = (int)letter;
            letters[letterCode]++;
        }

        foreach (char letter in s2.ToCharArray()) 
        { 
            int letterCode = (int) letter;
            letters[letterCode]--;
            if (letters[letterCode] == -1) return false;
        }

        return true;
    }

}
