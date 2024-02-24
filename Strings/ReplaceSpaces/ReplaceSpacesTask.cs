using System.Text;

namespace Strings;

public class ReplaceSpacesTask
{
    public string ReplaceSpaces(string s, int length)
    {
        StringBuilder sb = new();
        int i = 0;
        for (i = 0; i < length; i++)
        {
            if (char.IsWhiteSpace(s[i])) 
                sb.Append("%20");
            else 
                sb.Append(s[i]);
        }
        return sb.ToString();
    }
}
